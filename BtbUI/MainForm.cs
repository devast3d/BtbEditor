using BTBLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BtbUI
{
	public partial class MainForm : Form
	{
		private enum NodeTypes
		{
			MapHeader,
			Objectives,
			Obstacles,
			Obstacle,
			Regions,
			Region,
		}

		private class TagData
		{
			public NodeTypes NodeType;
			public object Link;

			public TagData(NodeTypes nodeType, object link)
			{
				NodeType = nodeType;
				Link = link;
			}

			public BTBLib.Region GetRegionLink()
			{
				return NodeType == NodeTypes.Region ? (BTBLib.Region)Link : null;
			}
		}

		private class DrawData
		{
			private List<BTBLib.Region> _regionsToDraw;

			public bool DrawRegions { get; set; }
			public IList<BTBLib.Region> RegionsToDraw { get { return _regionsToDraw; } }

			public DrawData()
			{
				_regionsToDraw = new List<BTBLib.Region>();
			}

			public void AddRegion(BTBLib.Region value)
			{
				if (!_regionsToDraw.Contains(value))
				{
					_regionsToDraw.Add(value);
				}
			}

			public void RemoveRegion(BTBLib.Region value)
			{
				if (_regionsToDraw.Contains(value))
				{
					_regionsToDraw.Remove(value);
				}
			}

			public void SetRegion(bool show, BTBLib.Region value)
			{
				if (show)
				{
					AddRegion(value);
				}
				else
				{
					RemoveRegion(value);
				}
			}

			public bool ContainsRegion(BTBLib.Region value)
			{
				return _regionsToDraw.Contains(value);
			}

			public void ClearRegions()
			{
				_regionsToDraw.Clear();
			}
		}


		private Battle _battle;
		private Image _background;

		private DrawData _drawData;
		private bool _redrawEnabled;

		private float _regionPenWidth;
		private float _regionPointSize;
		private float _gridSize;
		private bool _drawGrid;

		private float _zoom;
		private Point _translation;
		private bool _panning;
		private Point _prevMouseLocation;

		private BTBLib.Region _highlightedRegion;
		private BTBLib.Region _selectedRegion;

		public MainForm()
		{
			InitializeComponent();

			_drawData = new DrawData();
			_drawData.DrawRegions = true;

			ResetTransform();
			SetRegionPenWidth(2.0f);
			SetRegionPointSize(3.0f);
			SetGridSize(10.0f);
			SetDrawGrid(true);

			_draw_panel.MouseWheel += _draw_panel_MouseWheel;
			_battle_treeView.AfterCheck += _battle_treeView_AfterCheck;

			_redrawEnabled = true;
		}


		private void ShowError(string text)
		{
			MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void LoadBackground(string path)
		{
			try
			{
				Image image = Image.FromFile(path);
				_background = image;
			}
			catch (Exception ex)
			{
				ShowError(ex.ToString());
			}
		}

		private void FindAndLoadBackground(string path)
		{
			string[] files = Directory.GetFiles(path, "*.bmp");
			if (files.Length > 0)
			{
				LoadBackground(files[0]);
			}
		}

		private void OpenAndLoadBackground()
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "bmp files (*.bmp)|*.bmp|All files(*.*)|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				LoadBackground(dialog.FileName);
			}
		}

		private void FillTree()
		{
			TreeNodeCollection nodes = _battle_treeView.Nodes;
			nodes.Clear();

			TreeNode headerNode = nodes.Add("Map Header");
			headerNode.Tag = new TagData(NodeTypes.MapHeader, null);

			TreeNode objectivesNode = nodes.Add("Objectives");
			objectivesNode.Tag = new TagData(NodeTypes.Objectives, null);

			TreeNode obstaclesNode = nodes.Add("Obstacles");
			obstaclesNode.Tag = new TagData(NodeTypes.Obstacles, null);
			obstaclesNode.Checked = true;

			foreach (BTBLib.Obstacle obstacle in _battle.Obstacles)
			{
				TreeNode obstacleNode = obstaclesNode.Nodes.Add("Obstacle");
				obstacleNode.Tag = new TagData(NodeTypes.Obstacle, obstacle);
			}

			TreeNode regionsNode = nodes.Add("Regions");
			regionsNode.Tag = new TagData(NodeTypes.Regions, null);
			regionsNode.Checked = true;

			foreach (BTBLib.Region region in _battle.Regions)
			{
				TreeNode regionNode = regionsNode.Nodes.Add(region.Name);
				regionNode.Tag = new TagData(NodeTypes.Region, region);
			}
		}

		private TreeNode GetRegionsNode()
		{
			return _battle_treeView.Nodes[3];
		}

		private void OpenBattle(string path)
		{
			if (!File.Exists(path))
			{
				return;
			}

			Battle battle = null;
			try
			{
				battle = BTBLoader.Load(path);
			}
			catch (Exception ex)
			{
				ShowError(ex.ToString());
				return;
			}

			DisableRedraw();

			_battle = battle;
			_drawData.ClearRegions();

			_region_groupBox.Enabled = true;
			_current_textBox.Text = path;
			FindAndLoadBackground(Path.GetDirectoryName(path));
			SetHighlightedRegion(null);
			SetSelectedRegion(null);

			ResetTransform();
			FillTree();

			EnableRedraw();
			Redraw();
		}


		private void DisableRedraw()
		{
			_redrawEnabled = false;
		}

		private void EnableRedraw()
		{
			_redrawEnabled = true;
		}

		private void Redraw()
		{
			if (_redrawEnabled)
			{
				_draw_panel.Invalidate();
			}
		}

		private void DrawGrid(Graphics graphics)
		{
			float range = 500;
			Pen pen = new Pen(Color.FromArgb(118, 118, 118), 1f / _zoom);
			for (float v = _gridSize; v <= range; v += _gridSize)
			{
				graphics.DrawLine(pen, v, range, v, -range);
				graphics.DrawLine(pen, -v, range, -v, -range);
				graphics.DrawLine(pen, range, v, -range, v);
				graphics.DrawLine(pen, range, -v, -range, -v);
			}
			pen = new Pen(Color.Black, 1f / _zoom);
			graphics.DrawLine(pen, 0, range, 0, -range);
			graphics.DrawLine(pen, range, 0, -range, 0);
		}

		private void DrawRegion(Graphics graphics, Color color, bool drawPoints, BTBLib.Region region)
		{
			Pen pen = new Pen(color, _regionPenWidth / _zoom);
			Brush brush = new SolidBrush(color);
			foreach (var segment in region.Lines)
			{
				int startX = segment.StartX / 8;
				int startY = (_battle.Height - segment.StartY) / 8;
				int endX = segment.EndX / 8;
				int endY = (_battle.Height - segment.EndY) / 8;
				graphics.DrawLine(pen, startX, startY, endX, endY);
				if (drawPoints)
				{
					graphics.FillRectangle(brush, startX - _regionPointSize / 2, startY - _regionPointSize / 2, _regionPointSize, _regionPointSize);
				}
			}
			if (drawPoints)
			{
				if (!region.IsClosed && region.Lines.Count > 0)
				{
					BTBLib.Region.LineSegment segment = region.Lines[region.Lines.Count - 1];
					int endX = segment.EndX / 8;
					int endY = (_battle.Height - segment.EndY) / 8;
					graphics.FillRectangle(brush, endX - _regionPointSize / 2, endY - _regionPointSize / 2, _regionPointSize, _regionPointSize);
				}
			}
		}

		private void Draw(Graphics graphics)
		{
			if (_battle == null)
			{
				return;
			}

			int battleWidth = _battle.Width / 8;
			int battleHeight = _battle.Height / 8;

			graphics.TranslateTransform(_translation.X, _translation.Y);
			graphics.ScaleTransform(_zoom, _zoom);

			if (_drawGrid)
			{
				DrawGrid(graphics);
			}

			if (_background != null)
			{
				graphics.DrawImage(_background, new Rectangle(0, 0, battleWidth, battleHeight));
			}

			if (_drawData.DrawRegions)
			{
				foreach (BTBLib.Region region in _drawData.RegionsToDraw)
				{
					DrawRegion(graphics, Color.White, false, region);
				}
				if (_selectedRegion != null &&  _drawData.ContainsRegion(_selectedRegion))
				{
					DrawRegion(graphics, Color.FromArgb(200, 0, 0), true, _selectedRegion);
				}
				if (_highlightedRegion != null && _highlightedRegion != _selectedRegion && _drawData.ContainsRegion(_highlightedRegion))
				{
					DrawRegion(graphics, Color.FromArgb(255, 0, 0), false, _highlightedRegion);
				}
			}
		}


		private void SetRegionPenWidth(float value)
		{
			if (value != _regionPenWidth)
			{
				_regionPenWidth = Math.Max(1, value);
				if (_regionPenWidth != (float)_regionPenWidth_numericUpDown.Value)
				{
					_regionPenWidth_numericUpDown.Value = (decimal)_regionPenWidth;
				}
				Redraw();
			}
		}

		private void SetRegionPointSize(float value)
		{
			if (value != _regionPointSize)
			{
				_regionPointSize = Math.Max(1, value);
				if (_regionPointSize != (float)_regionPointSize_numericUpDown.Value)
				{
					_regionPointSize_numericUpDown.Value = (decimal)_regionPointSize;
				}
				Redraw();
			}
		}
		
		private void SelectAllRegions()
		{
			_drawData.ClearRegions();
			foreach (BTBLib.Region region in _battle.Regions)
			{
				_drawData.AddRegion(region);
			}
			UpdateTreeViewRegions();
			Redraw();
		}

		private void SelectAllClosedRegions()
		{
			_drawData.ClearRegions();
			foreach (BTBLib.Region region in _battle.Regions)
			{
				if (region.IsClosed)
				{
					_drawData.AddRegion(region);
				}
			}
			UpdateTreeViewRegions();
			Redraw();
		}

		private void SelectAllOpenRegions()
		{
			_drawData.ClearRegions();
			foreach (BTBLib.Region region in _battle.Regions)
			{
				if (!region.IsClosed)
				{
					_drawData.AddRegion(region);
				}
			}
			UpdateTreeViewRegions();
			Redraw();
		}

		private void DeselectAllRegions()
		{
			_drawData.ClearRegions();
			UpdateTreeViewRegions();
			Redraw();
		}

		private void UpdateTreeViewRegions()
		{
			TreeNode regionsNode = GetRegionsNode();
			foreach (TreeNode node in regionsNode.Nodes)
			{
				TagData tagData = node.Tag as TagData;
				BTBLib.Region region = tagData.GetRegionLink();
				node.Checked = _drawData.ContainsRegion(region);
			}
		}

		private void SetHighlightedRegion(BTBLib.Region value)
		{
			if (_highlightedRegion != value)
			{
				_highlightedRegion = value;
				Redraw();
			}
		}

		private void SetSelectedRegion(BTBLib.Region value)
		{
			if (_selectedRegion != value)
			{
				_selectedRegion = value;
				Redraw();
			}
		}


		private void SetGridSize(float value)
		{
			if (value != _gridSize)
			{
				_gridSize = Math.Max(1, value);
				if (_gridSize != (float)_canvasGridSize_numericUpDown.Value)
				{
					_canvasGridSize_numericUpDown.Value = (decimal)_gridSize;
				}
				Redraw();
			}
		}

		private void SetDrawGrid(bool value)
		{
			if (value != _drawGrid)
			{
				_drawGrid = value;
				if (_drawGrid != _canvasDrawGrid_checkBox.Checked)
				{
					_canvasDrawGrid_checkBox.Checked = _drawGrid;
				}
				Redraw();
			}
		}


		private void ClearDetailsPanel()
		{
			_selectedItem_panel.Controls.Clear();
		}

		private void SetDetailsPanelControl(Control value)
		{
			ClearDetailsPanel();
			_selectedItem_panel.Controls.Add(value);
			value.Dock = DockStyle.Fill;
		}


		private void SetZoom(float value)
		{
			if (value != _zoom)
			{
				_zoom = Math.Max(1, value);
				if (_zoom != (float)_zoom_numericUpDown.Value)
				{
					_zoom_numericUpDown.Value = (decimal)_zoom;
				}
				Redraw();
			}
		}

		private void ResetZoom()
		{
			SetZoom(3.0f);
		}

		private void ResetTranslation()
		{
			SetTranslation(0, 0);
		}

		private void ResetTransform()
		{
			ResetZoom();
			ResetTranslation();
		}

		private void SetTranslation(int valueX, int valueY)
		{
			if (valueX != _translation.X || valueY != _translation.Y)
			{
				_translation.X = valueX;
				_translation.Y = valueY;

				if (_translation.X != (int)_translationX_numericUpDown.Value)
				{
					_translationX_numericUpDown.Value = (decimal)_translation.X;
				}
				if (_translation.Y != (int)_translationY_numericUpDown.Value)
				{
					_translationY_numericUpDown.Value = (decimal)_translation.Y;
				}
				Redraw();
			}
		}


		private void _setbg_button_Click(object sender, EventArgs e)
		{
			OpenAndLoadBackground();
		}

		private void _open_button_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "btb files (*.btb)|*.btb|All files(*.*)|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				OpenBattle(dialog.FileName);
			}
		}


		private void _battle_treeView_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
			{
				TreeNode node = e.Node;
				bool check = node.Checked;
				TagData tagData = node.Tag as TagData;
				NodeTypes nodeType = (NodeTypes)tagData.NodeType;

				switch (nodeType)
				{
					case NodeTypes.Regions:
						_drawData.DrawRegions = check;
						break;

					case NodeTypes.Region:
						_drawData.SetRegion(check, tagData.GetRegionLink());
						break;
				}

				Redraw();
			}
		}

		private void _battle_treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode node = e.Node;
			if (node != null)
			{
				TagData tagData = node.Tag as TagData;
				NodeTypes nodeType = tagData.NodeType;

				switch (nodeType)
				{
					case NodeTypes.MapHeader:
						{
							MapHeaderControl control = new MapHeaderControl();
							control.SetData(_battle);
							SetDetailsPanelControl(control);
						}
						break;

					case NodeTypes.Region:
						{
							RegionControl control = new RegionControl();
							control.SetData(tagData.GetRegionLink());
							SetDetailsPanelControl(control);
							SetSelectedRegion(tagData.GetRegionLink());
						}
						break;

					default:
						{
							ClearDetailsPanel();
							SetSelectedRegion(null);
						}
						break;

				}
			}
			else
			{
				ClearDetailsPanel();
				SetSelectedRegion(null);
			}
		}

		private void _battle_treeView_MouseMove(object sender, MouseEventArgs e)
		{
			TreeNode node = _battle_treeView.GetNodeAt(e.Location);
			if (node != null)
			{
				TagData tagData = node.Tag as TagData;
				if (tagData.NodeType == NodeTypes.Region)
				{
					SetHighlightedRegion(tagData.GetRegionLink());
				}
				else
				{
					SetHighlightedRegion(null);
				}
			}
			else
			{
				SetHighlightedRegion(null);
			}
		}

		private void _battle_treeView_MouseLeave(object sender, EventArgs e)
		{
			SetHighlightedRegion(null);
		}


		private void _draw_panel_Paint(object sender, PaintEventArgs e)
		{
			Draw(e.Graphics);
		}

		private void _draw_panel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta < 0)
			{
				SetZoom(_zoom - (float)_zoom_numericUpDown.Increment);
			}
			else if (e.Delta > 0)
			{
				SetZoom(_zoom + (float)_zoom_numericUpDown.Increment);
			}
		}

		private void _draw_panel_MouseHover(object sender, EventArgs e)
		{
			_draw_panel.Focus();
		}

		private void _draw_panel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				_panning = true;
				_prevMouseLocation = e.Location;
			}
		}

		private void _draw_panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (_panning)
			{
				int deltaX = e.Location.X - _prevMouseLocation.X;
				int deltaY = e.Location.Y - _prevMouseLocation.Y;

				SetTranslation(_translation.X + deltaX, _translation.Y + deltaY);

				_prevMouseLocation = e.Location;

				Redraw();
			}
		}

		private void _draw_panel_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				_panning = false;
			}
		}


		private void _regionPenWidth_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRegionPenWidth((float)_regionPenWidth_numericUpDown.Value);
		}

		private void _regionPointSize_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRegionPointSize((float)_regionPointSize_numericUpDown.Value);
		}

		private void _regionSelectAll_button_Click(object sender, EventArgs e)
		{
			SelectAllRegions();
		}

		private void _regionSelectAllClosed_button_Click(object sender, EventArgs e)
		{
			SelectAllClosedRegions();
		}

		private void _regionSelectAllOpen_button_Click(object sender, EventArgs e)
		{
			SelectAllOpenRegions();
		}

		private void _regionDeselectAll_button_Click(object sender, EventArgs e)
		{
			DeselectAllRegions();
		}
		

		private void _canvasDrawGrid_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			SetDrawGrid(_canvasDrawGrid_checkBox.Checked);
		}

		private void _canvasGridSize_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetGridSize((float)_canvasGridSize_numericUpDown.Value);
		}


		private void _zoom_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetZoom((float)_zoom_numericUpDown.Value);
		}

		private void _translationX_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetTranslation((int)_translationX_numericUpDown.Value, _translation.Y);
		}

		private void _translationY_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetTranslation(_translation.X, (int)_translationY_numericUpDown.Value);
		}

		private void _resetZoom_button_Click(object sender, EventArgs e)
		{
			ResetZoom();
		}

		private void _resetTranslation_button_Click(object sender, EventArgs e)
		{
			ResetTranslation();
		}

		private void _resetTransform_button_Click(object sender, EventArgs e)
		{
			ResetTransform();
		}
	}
}

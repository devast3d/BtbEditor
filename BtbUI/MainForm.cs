using BTBLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
			GameObjects,
			GameObject
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

			public BTBLib.Obstacle GetObstacleLink()
			{
				return NodeType == NodeTypes.Obstacle ? (BTBLib.Obstacle)Link : null;
			}

			public BTBLib.Region GetRegionLink()
			{
				return NodeType == NodeTypes.Region ? (BTBLib.Region)Link : null;
			}
		}

		private class DrawData
		{
			private List<BTBLib.Obstacle> _obstaclesToDraw;
			private List<BTBLib.Region> _regionsToDraw;


			public bool DrawObstacels { get; set; }
			public IList<BTBLib.Obstacle> ObstacelsToDraw { get { return _obstaclesToDraw; } }
			public bool DrawRegions { get; set; }
			public IList<BTBLib.Region> RegionsToDraw { get { return _regionsToDraw; } }


			public DrawData()
			{
				_obstaclesToDraw = new List<BTBLib.Obstacle>();
				_regionsToDraw = new List<BTBLib.Region>();
			}


			public void AddObstacle(BTBLib.Obstacle value)
			{
				if (!_obstaclesToDraw.Contains(value))
				{
					_obstaclesToDraw.Add(value);
				}
			}

			public void RemoveObstacle(BTBLib.Obstacle value)
			{
				if (_obstaclesToDraw.Contains(value))
				{
					_obstaclesToDraw.Remove(value);
				}
			}

			public void SetObstacle(bool show, BTBLib.Obstacle value)
			{
				if (show)
				{
					AddObstacle(value);
				}
				else
				{
					RemoveObstacle(value);
				}
			}

			public bool ContainsObstacle(BTBLib.Obstacle value)
			{
				return _obstaclesToDraw.Contains(value);
			}

			public void ClearObstacles()
			{
				_obstaclesToDraw.Clear();
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


			public void Clear()
			{
				ClearObstacles();
				ClearRegions();
			}
		}


		private Battle _battle;
		private Image _background;

		private DrawData _drawData;
		private bool _redrawEnabled;

		private float _regionPenWidth;
		private float _regionPointSize;
		private bool _fillSelectedRegion;

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
			_drawData.DrawObstacels = true;
			_drawData.DrawRegions = true;

			ResetTransform();
			SetRegionPenWidth(2.0f);
			SetRegionPointSize(3.0f);
			SetGridSize(10.0f);
			SetDrawGrid(true);
			SetFillSelectedRegion(false);

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
			string mapPath = path + "/map.bmp";
			if (File.Exists(mapPath))
			{
				LoadBackground(mapPath);
				return;
			}

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

			TreeNode gameObjectsNode = nodes.Add("Game Objects");
			gameObjectsNode.Tag = new TagData(NodeTypes.GameObjects, null);
			gameObjectsNode.Checked = true;

			foreach (BTBLib.Node gameObject in _battle.Nodes)
			{
				TreeNode gameObjetctNode = gameObjectsNode.Nodes.Add("GameObject");
				gameObjetctNode.Tag = new TagData(NodeTypes.GameObject, gameObject);
			}
		}

		private TreeNode GetObstaclesNode()
		{
			return _battle_treeView.Nodes[2];
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
			_drawData.Clear();

			_region_groupBox.Enabled = true;
			_obstacle_groupBox.Enabled = true;
			_current_textBox.Text = path;
			_background = null;
			FindAndLoadBackground(Path.GetDirectoryName(path));
			SetHighlightedRegion(null);
			SetSelectedRegion(null);

			ResetTransform();
			FillTree();

			EnableRedraw();
			Redraw();
            _save_button.Enabled = true;
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

		private void DrawRegion(Graphics graphics, Color color, bool drawPoints, bool fill, BTBLib.Region region)
		{
			Pen pen = new Pen(color, _regionPenWidth / _zoom);
			Brush brush = new SolidBrush(color);
			Point[] points = null;
			bool shouldFill = fill && region.IsClosed;
			if (shouldFill)
			{
				points = new Point[region.Lines.Count];
			}
			for (int i = 0; i < region.Lines.Count; ++i)
			{
				var segment = region.Lines[i];
				int startX = segment.StartX / 8;
				int startY = (_battle.Height - segment.StartY) / 8;
				int endX = segment.EndX / 8;
				int endY = (_battle.Height - segment.EndY) / 8;
				graphics.DrawLine(pen, startX, startY, endX, endY);
				if (drawPoints)
				{
					graphics.FillRectangle(brush, startX - _regionPointSize / 2, startY - _regionPointSize / 2, _regionPointSize, _regionPointSize);
				}
				if (shouldFill)
				{
					points[i] = new Point(startX, startY);
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
			if (shouldFill)
			{
				Brush regionBrush = new SolidBrush(Color.FromArgb(128, color.R, color.G, color.B));
				if (region.IsBoundaryInversed)
				{
					System.Drawing.Region graphicsRegion = new System.Drawing.Region();
					graphicsRegion.MakeInfinite();
					GraphicsPath path = new GraphicsPath();
					path.AddPolygon(points);
					graphicsRegion.Exclude(path);
					graphics.FillRegion(regionBrush, graphicsRegion);
				}
				else
				{
					graphics.FillPolygon(regionBrush, points);
				}
			}
		}

		private void DrawObstacle(Graphics graphics, Color color, bool fill, BTBLib.Obstacle obstacle)
		{
			Pen pen = new Pen(color, 2.0f / _zoom);

			float radius = obstacle.Radius;// * 2;
			float size = radius * 2;

			int div = 8;
			graphics.DrawEllipse(pen, (obstacle.X - radius) / div, (_battle.Height - obstacle.Y - radius) / div, size / div, size / div);
			//graphics.DrawRectangle(pen, (obstacle.X - radius) / 8, (_battle.Height - obstacle.Y - radius) / 8, size, size);

			graphics.FillRectangle(new SolidBrush(color), (obstacle.X) / 8f - 0.5f, (_battle.Height - obstacle.Y) / 8f - 0.5f, 1f, 1f);
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
					DrawRegion(graphics, Color.White, false, false, region);
				}
				if (_selectedRegion != null && _drawData.ContainsRegion(_selectedRegion))
				{
					DrawRegion(graphics, Color.FromArgb(200, 0, 0), true, _fillSelectedRegion, _selectedRegion);
				}
				if (_highlightedRegion != null && _highlightedRegion != _selectedRegion && _drawData.ContainsRegion(_highlightedRegion))
				{
					DrawRegion(graphics, Color.FromArgb(255, 0, 0), false, false, _highlightedRegion);
				}
			}

			if (_drawData.DrawObstacels)
			{
				foreach (BTBLib.Obstacle obstacle in _drawData.ObstacelsToDraw)
				{
					Color c;
					if (obstacle.IsMoveBlock && obstacle.IsProjBlock)
					{
						c = Color.Purple;
					}
					else if (obstacle.IsMoveBlock)
					{
						c = Color.Red;
					}
					else if (obstacle.IsProjBlock)
					{
						c = Color.Blue;
					}
					else
					{
						c = Color.Black;
					}
					DrawObstacle(graphics, c, false, obstacle);
				}
			}
		}


		private void SelectAllObstacles()
		{
			_drawData.ClearObstacles();
			foreach (BTBLib.Obstacle obstacle in _battle.Obstacles)
			{
				_drawData.AddObstacle(obstacle);
			}
			UpdateTreeViewObstacles();
			Redraw();
		}

		private void SelectAllMoveBlockObstacles()
		{
			_drawData.ClearObstacles();
			foreach (BTBLib.Obstacle obstacle in _battle.Obstacles)
			{
				if (obstacle.IsMoveBlock)
				{
					_drawData.AddObstacle(obstacle);
				}
			}
			UpdateTreeViewObstacles();
			Redraw();
		}

		private void SelectAllProjBlockObstacles()
		{
			_drawData.ClearObstacles();
			foreach (BTBLib.Obstacle obstacle in _battle.Obstacles)
			{
				if (obstacle.IsProjBlock)
				{
					_drawData.AddObstacle(obstacle);
				}
			}
			UpdateTreeViewObstacles();
			Redraw();
		}

		private void DeselectAllObstacles()
		{
			_drawData.ClearObstacles();
			UpdateTreeViewObstacles();
			Redraw();
		}

		private void UpdateTreeViewObstacles()
		{
			TreeNode obstaclesNode = GetObstaclesNode();
			foreach (TreeNode node in obstaclesNode.Nodes)
			{
				TagData tagData = node.Tag as TagData;
				BTBLib.Obstacle obstacle = tagData.GetObstacleLink();
				node.Checked = _drawData.ContainsObstacle(obstacle);
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

		private void SetFillSelectedRegion(bool value)
		{
			if (value != _fillSelectedRegion)
			{
				_fillSelectedRegion = value;
				if (_fillSelectedRegion != _regionFillSelected_checkBox.Checked)
				{
					_regionFillSelected_checkBox.Checked = _fillSelectedRegion;
				}
				Redraw();
			}
		}

		private void CalcWalkableArea()
		{
			if (_battle == null)
			{
				return;
			}

			int width = _battle.Width / 8;
			int height = _battle.Height / 8;

			Image image = new Bitmap(width, height);
			Graphics graphics = Graphics.FromImage(image);
			graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, width, height));

			BTBLib.Region battleBoundary = null;
			List<BTBLib.Region> boundaries = new List<BTBLib.Region>();
			List<BTBLib.Region> inverseBoundaries = new List<BTBLib.Region>();

			foreach (BTBLib.Region region in _battle.Regions)
			{
				if (region.IsClosed)
				{
					if (region.IsBattleBoundary)
					{
						battleBoundary = region;
					}
					else if (region.IsBoundaryInversed)
					{
						inverseBoundaries.Add(region);
					}
					else if (region.IsBoundary)
					{
						boundaries.Add(region);
					}
				}
			}

			if (battleBoundary == null)
			{
				return;
			}

			boundaries.Insert(0, battleBoundary);			

			System.Drawing.Region graphicsRegion = new System.Drawing.Region(new Rectangle(0, 0, width, height));

			foreach (BTBLib.Region region in boundaries)
			{
				Point[] points = new Point[region.Lines.Count];
				for (int i = 0; i < points.Length; ++i)
				{
					var segment = region.Lines[i];
					points[i] = new Point(segment.StartX / 8, height - segment.StartY / 8);
				}

				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddPolygon(points);

				graphicsRegion.Intersect(graphicsPath);
			}

			foreach (BTBLib.Region region in inverseBoundaries)
			{
				Point[] points = new Point[region.Lines.Count];
				for (int i = 0; i < points.Length; ++i)
				{
					var segment = region.Lines[i];
					points[i] = new Point(segment.StartX / 8, height - segment.StartY / 8);
				}

				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddPolygon(points);

				graphicsRegion.Exclude(graphicsPath);
			}

			graphics.FillRegion(new SolidBrush(Color.Red), graphicsRegion);

			//Form form = new Form();
			//form.ClientSize = new Size(width * 3, height * 3);
			//PictureBox pictureBox = new PictureBox();
			//pictureBox.Image = image;
			//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			//form.Controls.Add(pictureBox);
			//pictureBox.Dock = DockStyle.Fill;
			//form.Show();

			ImageForm form = new ImageForm();
			form.SetImage(image);
			form.ShowDialog();
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
					case NodeTypes.Obstacles:
						_drawData.DrawObstacels = check;
						break;

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


		private void _obstacleSelectAll_button_Click(object sender, EventArgs e)
		{
			SelectAllObstacles();
		}

		private void _obstacleSelectMove_button_Click(object sender, EventArgs e)
		{
			SelectAllMoveBlockObstacles();
		}

		private void _obstacleSelectProj_button_Click(object sender, EventArgs e)
		{
			SelectAllProjBlockObstacles();
		}

		private void _obstacleDeselectAll_button_Click(object sender, EventArgs e)
		{
			DeselectAllObstacles();
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
		
		private void _regionFillSelected_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			SetFillSelectedRegion(_regionFillSelected_checkBox.Checked);
		}
		
		private void _calcWalkable_button_Click(object sender, EventArgs e)
		{
			CalcWalkableArea();
		}

		private void _regionPenWidth_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRegionPenWidth((float)_regionPenWidth_numericUpDown.Value);
		}

		private void _regionPointSize_numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			SetRegionPointSize((float)_regionPointSize_numericUpDown.Value);
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

        private void _save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "btb files (*.btb)|*.btb|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BTBLib.BTBSaver.Save(this._battle, dialog.FileName);
            }
        }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTBLib;

namespace BtbUI
{
	public partial class ObjectControl : UserControl
	{
		BTBLib.Node _node;

		public ObjectControl()
		{
			InitializeComponent();

			ListViewItem item;

			item = new ListViewItem(new string[] { "X,Y", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Radius", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Direction", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "NodeId", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "UnitId", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "ScriptFunc", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Usage", string.Empty });
			_properties_listView.Items.Add(item);
		}

		public void SetData(BTBLib.Node node)
		{
			_node = node;
			UpdateUI();
		}

		private ListViewItem.ListViewSubItem GetValueSubItem(int itemIndex)
		{
			return _properties_listView.Items[itemIndex].SubItems[1];
		}

		private string VertexToString(int x, int y)
		{
			return string.Format("({0},{1})", (x / 8.0f).ToString(), (y / 8.0f).ToString());
		}

		private void UpdateUI()
		{
			GetValueSubItem(0).Text = VertexToString(_node.X, _node.Y);
			GetValueSubItem(1).Text = (_node.Radius / 8.0f).ToString();
			GetValueSubItem(2).Text = _node.Direction.ToString();
			GetValueSubItem(3).Text = _node.NodeID.ToString();
			GetValueSubItem(4).Text = _node.UnitID.ToString();
			GetValueSubItem(5).Text = _node.ScriptFunc.ToString();
			GetValueSubItem(6).Text = Convert.ToString((ushort)_node.Usage, 2);
		}

		private void _copyStart_button_Click(object sender, EventArgs e)
		{
			//StringBuilder sb = new StringBuilder();
			//foreach (var segment in _region.Lines)
			//{
			//	sb.Append(VertexToString(-segment.StartX, segment.StartY));
			//}
			//string text = sb.ToString();
			//Clipboard.SetText(text);
		}

		private void ShowPropertyEditor(int propertyIndex)
		{
			//switch (propertyIndex)
			//{
			//	case 0:
			//		{
			//			//TODO
			//		}
			//		break;

			//	case 1:
			//		{
			//			RegionFlagsForm dialog = new RegionFlagsForm();
			//			dialog.SetData(_region);
			//			dialog.ShowDialog();
			//		}
			//		break;
			//}
		}

		private void _properties_listView_DoubleClick(object sender, EventArgs e)
		{
			//if (_properties_listView.SelectedIndices.Count > 0)
			//{
			//	ShowPropertyEditor(_properties_listView.SelectedIndices[0]);
			//}
		}
	}
}

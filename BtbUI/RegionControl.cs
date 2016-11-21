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
	public partial class RegionControl : UserControl
	{
		BTBLib.Region _region;

		public RegionControl()
		{
			InitializeComponent();

			ListViewItem item;

			item = new ListViewItem(new string[] { "Name", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Flags", string.Empty });
			_properties_listView.Items.Add(item);
		}

		public void SetData(BTBLib.Region region)
		{
			_region = region;
			UpdateUI();
		}

		private ListViewItem.ListViewSubItem GetValueSubItem(int itemIndex)
		{
			return _properties_listView.Items[itemIndex].SubItems[1];
		}

		private string VertexToString(int x, int y)
		{
			return string.Format("({0},{1})", (x / 8).ToString(), (y / 8).ToString());
		}

		private void UpdateUI()
		{
			GetValueSubItem(0).Text = _region.Name;
			GetValueSubItem(1).Text = Convert.ToString((ushort)_region.Flags, 2);
			_segments_listView.Items.Clear();
			foreach (var segment in _region.Lines)
			{
				ListViewItem item = new ListViewItem(new string[] { VertexToString(segment.StartX, segment.StartY), VertexToString(segment.EndX, segment.EndY) });
				_segments_listView.Items.Add(item);
			}
		}

		private void ShowPropertyEditor(int propertyIndex)
		{
			switch (propertyIndex)
			{
				case 0:
					{
						//TODO
					}
					break;

				case 1:
					{
						RegionFlagsForm dialog = new RegionFlagsForm();
						dialog.SetData(_region);
						dialog.ShowDialog();
					}
					break;
			}
		}

		private void _properties_listView_DoubleClick(object sender, EventArgs e)
		{
			if (_properties_listView.SelectedIndices.Count > 0)
			{
				ShowPropertyEditor(_properties_listView.SelectedIndices[0]);
			}
		}
	}
}

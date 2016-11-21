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
	public partial class RegionFlagsControl : UserControl
	{
		BTBLib.Region _region;

		public RegionFlagsControl()
		{
			InitializeComponent();
		}

		public void SetData(BTBLib.Region region)
		{
			_region = region;
			UpdateUI();
		}

		private void UpdateFlags()
		{
			_flags_textBox.Text = Convert.ToString(_region.Flags, 2);
		}

		private bool IsBitSet(int bitIndex)
		{
			return (_region.Flags & (1 << bitIndex)) != 0;
		}

		private void UpdateCheckBoxes()
		{
			uint flags = _region.Flags;
			_enabled_checkBox.Checked = IsBitSet(0);
			_closed_checkBox.Checked = IsBitSet(1);
			_path_checkBox.Checked = IsBitSet(2);
			_unknown1_checkBox.Checked = IsBitSet(3);
			_movement1_checkBox.Checked = IsBitSet(4);
			_battleRegion_checkBox.Checked = IsBitSet(5);
			_unknown2_checkBox.Checked = IsBitSet(6);
			_movement2_checkBox.Checked = IsBitSet(7);
			_p1_checkBox.Checked = IsBitSet(8);
			_p2_checkBox.Checked = IsBitSet(9);
			_visible_checkBox.Checked = IsBitSet(10);
		}

		private void UpdateUI()
		{
			UpdateFlags();
			UpdateCheckBoxes();
		}
	}
}

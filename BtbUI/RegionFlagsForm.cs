using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtbUI
{
	public partial class RegionFlagsForm : Form
	{
		public RegionFlagsForm()
		{
			InitializeComponent();
		}

		public void SetData(BTBLib.Region region)
		{
			regionFlagsControl1.SetData(region);
		}
	}
}

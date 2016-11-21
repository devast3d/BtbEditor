using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbUI
{
	public partial class AntiFlickerPanel : System.Windows.Forms.Panel
	{
		public AntiFlickerPanel()
		{
			this.SetStyle(
				System.Windows.Forms.ControlStyles.UserPaint |
				System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
				System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
				true);
		}
	}
}

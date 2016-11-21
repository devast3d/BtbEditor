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
	public partial class MapHeaderControl : UserControl
	{
		Battle _battle;

		public MapHeaderControl()
		{
			InitializeComponent();

			ListViewItem item;
			
			item = new ListViewItem(new string[] { "Map Width", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Map Height", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Merc Army", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "Enemy Army", string.Empty });
			_properties_listView.Items.Add(item);

			item = new ListViewItem(new string[] { "CTL", string.Empty });
			_properties_listView.Items.Add(item);
		}

		public void SetData(Battle battle)
		{
			_battle = battle;
			UpdateUI();
		}

		private ListViewItem.ListViewSubItem GetValueSubItem(int itemIndex)
		{
			return _properties_listView.Items[itemIndex].SubItems[1];
		}

		private void UpdateUI()
		{
			GetValueSubItem(0).Text = (_battle.Width / 8).ToString();
			GetValueSubItem(1).Text = (_battle.Height / 8).ToString();
			GetValueSubItem(2).Text = _battle.PlayerArmy;
			GetValueSubItem(3).Text = _battle.EnemyArmy;
			GetValueSubItem(4).Text = _battle.CTL;
		}
	}
}

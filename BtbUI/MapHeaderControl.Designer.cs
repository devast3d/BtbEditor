namespace BtbUI
{
	partial class MapHeaderControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._properties_listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// _properties_listView
			// 
			this._properties_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._properties_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this._properties_listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._properties_listView.FullRowSelect = true;
			this._properties_listView.GridLines = true;
			this._properties_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this._properties_listView.Location = new System.Drawing.Point(0, 0);
			this._properties_listView.Name = "_properties_listView";
			this._properties_listView.Size = new System.Drawing.Size(384, 297);
			this._properties_listView.TabIndex = 0;
			this._properties_listView.UseCompatibleStateImageBehavior = false;
			this._properties_listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 81;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Value";
			this.columnHeader2.Width = 228;
			// 
			// MapHeaderControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._properties_listView);
			this.Name = "MapHeaderControl";
			this.Size = new System.Drawing.Size(384, 297);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView _properties_listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}

namespace BtbUI
{
	partial class RegionControl
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
			this.label1 = new System.Windows.Forms.Label();
			this._segments_listView = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._copyStart_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _properties_listView
			// 
			this._properties_listView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this._properties_listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._properties_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._properties_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this._properties_listView.FullRowSelect = true;
			this._properties_listView.GridLines = true;
			this._properties_listView.Location = new System.Drawing.Point(0, 0);
			this._properties_listView.MultiSelect = false;
			this._properties_listView.Name = "_properties_listView";
			this._properties_listView.Size = new System.Drawing.Size(352, 58);
			this._properties_listView.TabIndex = 0;
			this._properties_listView.UseCompatibleStateImageBehavior = false;
			this._properties_listView.View = System.Windows.Forms.View.Details;
			this._properties_listView.DoubleClick += new System.EventHandler(this._properties_listView_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Value";
			this.columnHeader2.Width = 213;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Segments";
			// 
			// _segments_listView
			// 
			this._segments_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._segments_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._segments_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this._segments_listView.FullRowSelect = true;
			this._segments_listView.GridLines = true;
			this._segments_listView.Location = new System.Drawing.Point(0, 106);
			this._segments_listView.Name = "_segments_listView";
			this._segments_listView.Size = new System.Drawing.Size(352, 198);
			this._segments_listView.TabIndex = 2;
			this._segments_listView.UseCompatibleStateImageBehavior = false;
			this._segments_listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Start";
			this.columnHeader3.Width = 85;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "End";
			this.columnHeader4.Width = 94;
			// 
			// _copyStart_button
			// 
			this._copyStart_button.Location = new System.Drawing.Point(0, 77);
			this._copyStart_button.Name = "_copyStart_button";
			this._copyStart_button.Size = new System.Drawing.Size(100, 23);
			this._copyStart_button.TabIndex = 3;
			this._copyStart_button.Text = "Copy Start";
			this._copyStart_button.UseVisualStyleBackColor = true;
			this._copyStart_button.Click += new System.EventHandler(this._copyStart_button_Click);
			// 
			// RegionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._copyStart_button);
			this.Controls.Add(this._segments_listView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._properties_listView);
			this.Name = "RegionControl";
			this.Size = new System.Drawing.Size(352, 304);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView _properties_listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView _segments_listView;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button _copyStart_button;
	}
}

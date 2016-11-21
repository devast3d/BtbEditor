namespace BtbUI
{
	partial class RegionFlagsForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.regionFlagsControl1 = new BtbUI.RegionFlagsControl();
			this.SuspendLayout();
			// 
			// regionFlagsControl1
			// 
			this.regionFlagsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regionFlagsControl1.Location = new System.Drawing.Point(0, 0);
			this.regionFlagsControl1.Name = "regionFlagsControl1";
			this.regionFlagsControl1.Size = new System.Drawing.Size(217, 352);
			this.regionFlagsControl1.TabIndex = 0;
			// 
			// RegionFlagsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(217, 352);
			this.Controls.Add(this.regionFlagsControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegionFlagsForm";
			this.Text = "RegionFlagsForm";
			this.ResumeLayout(false);

		}

		#endregion

		private RegionFlagsControl regionFlagsControl1;
	}
}
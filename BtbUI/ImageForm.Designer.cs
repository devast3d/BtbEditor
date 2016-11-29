namespace BtbUI
{
	partial class ImageForm
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
			this._save_button = new System.Windows.Forms.Button();
			this._image_pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._image_pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _save_button
			// 
			this._save_button.Location = new System.Drawing.Point(12, 12);
			this._save_button.Name = "_save_button";
			this._save_button.Size = new System.Drawing.Size(100, 23);
			this._save_button.TabIndex = 0;
			this._save_button.Text = "Save Image";
			this._save_button.UseVisualStyleBackColor = true;
			this._save_button.Click += new System.EventHandler(this._save_button_Click);
			// 
			// _image_pictureBox
			// 
			this._image_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._image_pictureBox.BackColor = System.Drawing.Color.White;
			this._image_pictureBox.Location = new System.Drawing.Point(12, 41);
			this._image_pictureBox.Name = "_image_pictureBox";
			this._image_pictureBox.Size = new System.Drawing.Size(591, 435);
			this._image_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._image_pictureBox.TabIndex = 1;
			this._image_pictureBox.TabStop = false;
			// 
			// ImageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 488);
			this.Controls.Add(this._image_pictureBox);
			this.Controls.Add(this._save_button);
			this.Name = "ImageForm";
			this.Text = "Image";
			((System.ComponentModel.ISupportInitialize)(this._image_pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _save_button;
		private System.Windows.Forms.PictureBox _image_pictureBox;
	}
}
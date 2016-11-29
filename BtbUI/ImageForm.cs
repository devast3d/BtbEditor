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
	public partial class ImageForm : Form
	{
		private Image _image;

		public ImageForm()
		{
			InitializeComponent();
		}

		public void SetImage(Image image)
		{
			_image = image;
			_image_pictureBox.Image = image;
			//_image_pictureBox.Size = image.Size;
		}

		private void SaveImage()
		{
			if (_image == null)
			{
				return;
			}

			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "png files (*.png)|*.png|All files(*.*)|*.*";
			dialog.AddExtension = true;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_image.Save(dialog.FileName);
			}
		}

		private void _save_button_Click(object sender, EventArgs e)
		{
			SaveImage();
		}
	}
}

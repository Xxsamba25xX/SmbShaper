using SmbImager;
using SmbImager.MODEL;
using SmbImager.UTILS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		ColorConfiguration colorConfiguration = new ColorConfiguration();

		public Form1()
		{
			InitializeComponent();
			colorConfiguration.Fondo = Color.FromArgb(0, 162, 232);
			colorConfiguration.Limite = Color.FromArgb(255, 32, 255);
			colorConfiguration.Relleno = Color.FromArgb(181, 230, 29);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "image|*.png";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(opf.FileName);
				var colors = ImageUtils.GetColors((Bitmap)pictureBox1.Image);

				pictureBox2.Image = ImageUtils.CreateBitmap(Shaper.Normalize(colors, new Color[] { colors[0, 0] }, colorConfiguration));
				pictureBox2.Refresh();
			}
		}
	}
}

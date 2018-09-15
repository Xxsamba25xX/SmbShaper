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
        ColorConfiguration cf = new ColorConfiguration()
        {
            Fondo = Color.Black,
            Limite = Color.Magenta,
            Relleno = Color.LimeGreen
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "image|*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                var colors = ImageUtils.GetColors((Bitmap)pictureBox1.Image);
                var normalized = Shaper.Normalize(colors, new Color[] { colors[0, 0] }, cf);
                pictureBox2.Image = ImageUtils.CreateBitmap(normalized);
                pictureBox2.Refresh();
            }
        }


    }
}

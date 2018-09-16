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
        Random r = new Random();
        ColorConfiguration cf = new ColorConfiguration()
        {
            Fondo = Color.Black,
            Limite = Color.Magenta,
            ViejoLimite = Color.Red,
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
                var shapes = Shaper.Shapify(normalized, cf);
                Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.Yellow);
                    foreach (var item in shapes)
                    {
                        g.FillPolygon(new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))), item.Points);
                    }
                }
                pictureBox2.Image = b;
                pictureBox2.Refresh();
            }
        }

    }
}

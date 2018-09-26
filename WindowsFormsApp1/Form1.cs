using SmbImager;
using SmbImager.MODEL;
using SmbImager.UTILS;
using System;
using System.Drawing;
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
            InitializeComponentOwn(ControlFlags.Pictures);
        }

        private void InitializeComponentOwn(ControlFlags flags)
        {
            if (flags.HasFlag(ControlFlags.Pictures))
            {
                groupBox1.Location = new Point(10, button1.Bounds.Bottom + 6);
                groupBox1.Size = new Size(Math.Max(0, ((this.ClientSize.Width - 40) / 2)), Math.Max(0, this.ClientSize.Height - groupBox1.Location.Y - 10));
                groupBox2.Location = new Point(this.ClientSize.Width/2 + 10, button1.Bounds.Bottom + 6);
                groupBox2.Size = new Size(Math.Max(0, ((this.ClientSize.Width - 40) / 2)), Math.Max(0, this.ClientSize.Height - groupBox2.Location.Y - 10));
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            InitializeComponentOwn(ControlFlags.Pictures);
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                scrollPanel2.VerticalScroll.Value = e.NewValue;
            else
                scrollPanel2.HorizontalScroll.Value = e.NewValue;
        }

        private void scrollPanel2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                scrollPanel1.VerticalScroll.Value = e.NewValue;
            else
                scrollPanel1.HorizontalScroll.Value = e.NewValue;
        }
    }
}

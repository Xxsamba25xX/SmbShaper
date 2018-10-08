using SmbImager.MODEL;
using SmbImager.UTILS;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public partial class Form1 : Form
   {
      double progressValue = 0;
      object objProgress = new object();
      public double ProgressValue
      {
         get
         {
            lock (objProgress) return progressValue;
         }
         set
         {
            lock (objProgress) progressValue = value;
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         OpenFileDialog opf = new OpenFileDialog();
         opf.Filter = "image|*.png";
         if (opf.ShowDialog() == DialogResult.OK)
         {
            pictureBox1.Image = Image.FromFile(opf.FileName);
            Task.Run(() => Shapify(opf.FileName));
            timer1.Start();
         }
      }

      private void Shapify(string filename)
      {
         Color[,] colors = null;
         using (Image image = Image.FromFile(filename))
         {
            colors = ImageUtils.GetColors((Bitmap)image);
         }

         //ThreadSafe(() => lblPath.Text = filename);
         shaper.OnProgressChanged += new EventHandler<Progress>((x, y) =>
         {
            ProgressValue = y.Percentage;
         });

         var normalized = shaper.Normalize(colors, new Color[] { colors[0, 0] }, cf);
         var shapes = shaper.Shapify(normalized, cf);

         Bitmap b = new Bitmap(colors.GetLength(1), colors.GetLength(0));
         using (Graphics g = Graphics.FromImage(b))
         {
            g.Clear(Color.Yellow);
            foreach (var item in shapes)
            {
               item.RescanBound();
               g.FillPolygon(new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))), item.Points);
            }
         }
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         ThreadSafe(() => progressBar1.Value = (int)ProgressValue);
      }
   }
}

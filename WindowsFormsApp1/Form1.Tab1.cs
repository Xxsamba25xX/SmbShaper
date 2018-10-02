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
      private void button1_Click(object sender, EventArgs e)
      {
         OpenFileDialog opf = new OpenFileDialog();
         opf.Filter = "image|*.png";
         if (opf.ShowDialog() == DialogResult.OK)
         {
            Task.Run(() => Shapify(opf.FileName));
         }
      }

      private void Shapify(string filename)
      {
         Image image = Image.FromFile(filename);
         ThreadSafe(() => lblPath.Text = filename);
         ThreadSafe(() => pictureBox1.Image = image);
         var colors = ImageUtils.GetColors((Bitmap)image.Clone());
         shaper.OnProgressChanged += new EventHandler<Progress>((x, y) =>
         {
            var value = (int)Math.Round(y.Percentage);
            if (value % 10 == 0) Task.Run(() => {  ThreadSafe(() => progressBar1.Value = value); });
         });

         var normalized = shaper.Normalize(colors, new Color[] { colors[0, 0] }, cf);
         var shapes = shaper.Shapify(normalized, cf);

         Bitmap b = new Bitmap(image.Width, image.Height);
         using (Graphics g = Graphics.FromImage(b))
         {
            g.Clear(Color.Yellow);
            foreach (var item in shapes)
            {
               item.RescanBound();
               g.FillPolygon(new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256))), item.Points);
            }
         }
         ThreadSafe(() => pictureBox2.Image = b);
         ThreadSafe(() => pictureBox2.Refresh());
      }

      private void panel1_Scroll(object sender, ScrollEventArgs e)
      {
         if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            if (scrollPanel2.VerticalScroll.Minimum <= e.NewValue && scrollPanel2.VerticalScroll.Maximum >= e.NewValue) scrollPanel2.VerticalScroll.Value = e.NewValue;
            else
           if (scrollPanel2.HorizontalScroll.Minimum <= e.NewValue && scrollPanel2.HorizontalScroll.Maximum >= e.NewValue) scrollPanel2.HorizontalScroll.Value = e.NewValue;
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

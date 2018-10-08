using SmbImager;
using SmbImager.MODEL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public partial class Form1 : Form
   {
      protected Random r = new Random();
      protected ColorConfiguration cf = new ColorConfiguration()
      {
         Fondo = Color.Black,
         Limite = Color.Magenta,
         ViejoLimite = Color.Red,
         Relleno = Color.LimeGreen
      };
      protected Shaper shaper = new Shaper();

      public Form1()
      {
         InitializeComponent();
         InitializeComponentOwn(ControlFlags.Pictures);
      }

      private void InitializeComponentOwn(ControlFlags flags)
      {
         if (flags.HasFlag(ControlFlags.Pictures))
         {
            groupBox1.Location = new Point(10, pnPresentation.Bottom + 6);
            groupBox1.Size = new Size(Math.Max(0, (groupBox1.Parent.Width - 20)), Math.Max(0, groupBox1.Parent.Height - groupBox1.Location.Y - 10));
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
      }

      private void Form1_SizeChanged(object sender, EventArgs e)
      {
         InitializeComponentOwn(ControlFlags.Pictures);
      }

      private void ThreadSafe(Action action)
      {
         if (this.InvokeRequired)
            Invoke(new MethodInvoker(action));
         else
            action();
      }

      private void panel2_Paint(object sender, PaintEventArgs e)
      {

      }
   }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace SmbImager.Model
{
    public class Shape
    {
        public Rectangle Bound { get; private set; }

        public Point[] Points { get; private set; }

        public Shape(IEnumerable<Point> points = null)
        {
            Points = points?.ToArray() ?? new Point[] { };
        }

        public Shape(Point[] points)
        {
            Points = points ?? new Point[] { };
        }

        public void RescanBound()
        {
            if (Points == null || !Points.Any()) Bound = Rectangle.Empty;
            Rectangle r = new Rectangle(Points.First(), new Size());
            foreach (var item in Points)
            {
                var minX = Math.Min(r.Left, item.X);
                var minY = Math.Min(r.Top, item.Y);
                var maxX = Math.Max(r.Right, item.X);
                var maxY = Math.Max(r.Bottom, item.Y);
                r.Location = new Point(minX, minY);
                r.Size = new Size(maxX - minX, maxY - minY);
            }
            Bound = r;
        }

    }
}

using SmbImager.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
using SmbImager.UTILS;

namespace SmbImager
{
    public static class Shaper
    {
        public static Color[,] Normalize(Color[,] src, Color[] backgroundColors, ColorConfiguration configuration)
        {
            var bounds = new Rectangle(new Point(0, 0), new Size(src.GetLength(0), src.GetLength(1)));

            Color[,] result = new Color[bounds.Width, bounds.Height];
            for (int i = 0; i < src.GetLength(0); i++)
            {
                for (int j = 0; j < src.GetLength(1); j++)
                {

                    if (IsBackgroundColor(src[i, j], backgroundColors))
                    {
                        //Si es un color de fondo setearlo como color de fondo.
                        result[i, j] = configuration.Fondo;
                    }
                    else
                    {
                        //Obtenemos los puntos colindantes basicos(NSEO)
                        var colliders = GetColliders(new Point(i, j), false);
                        //se presume que no colinda con el fondo
                        result[i, j] = configuration.Relleno;
                        foreach (var item in colliders)
                        {
                            //si colinda con el fondo setearlo de color borde
                            if (IsOutOfBounds(bounds, item) || IsBackgroundColor(src[item.X, item.Y], backgroundColors))
                            {
                                result[i, j] = configuration.Limite;
                                break;
                            }
                        }
                        
                    }
                }
            }
            return result;
        }



        private static bool IsOutOfBounds(Rectangle bounds, Point item)
        {
            return (item.X < bounds.Left || item.X >= bounds.Right) ||
                   (item.Y < bounds.Top || item.Y >= bounds.Bottom);
        }

        private static Point[] GetColliders(Point point, bool fullColliders)
        {
            if (fullColliders) return new Point[]
            {
                point.Get(Cardinals.N),
                point.Get(Cardinals.NE) ,
                point.Get(Cardinals.E) ,
                point.Get(Cardinals.SE) ,
                point.Get(Cardinals.S),
                point.Get(Cardinals.SO),
                point.Get(Cardinals.O),
                point.Get(Cardinals.NO)
            };
            else return new Point[]
            {
                point.Get(Cardinals.N),
                point.Get(Cardinals.E) ,
                point.Get(Cardinals.S),
                point.Get(Cardinals.O),
            };
        }

        public static bool IsBackgroundColor(Color src, Color[] background)
        {
            foreach (var item in background)
            {
                if (item.ToArgb() == src.ToArgb()) return true;
            }
            return false;
        }

    }
}

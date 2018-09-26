using SmbImager.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
using SmbImager.UTILS;
using SmbImager.Model;

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
                        var colliders = GetColliders(new Point(i, j), Cardinal.N, false);
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

        public static List<Shape> Shapify(Color[,] src, ColorConfiguration configuration)
        {
            var shapeList = new List<Shape>();
            var lastPoint = new Point(-1, -1);
            var bound = new Rectangle(Point.Empty, new Size(src.GetLength(0), src.GetLength(1)));
            for (int y = 0; y < src.GetLength(1); y++)
            {
                for (int x = 0; x < src.GetLength(0); x++)
                {
                    var actualPoint = new Point(x, y);
                    if (src[actualPoint.X, actualPoint.Y] == configuration.Limite)
                    {
                        var pointsOfPath = new List<Point>() { actualPoint };
                        src[x, y] = configuration.ViejoLimite;
                        var newActualPoint = actualPoint;
                        var newLastPoint = GetColliders(actualPoint, Cardinal.O, false).First(j => IsOutOfBounds(bound, j) || src[j.X, j.Y] == configuration.Fondo);
                        while (true)
                        {
                            var newPointInfo = GetNextPoint(newActualPoint, newLastPoint, src, configuration);
                            newActualPoint = newPointInfo.newActualPoint;
                            newLastPoint = newPointInfo.newLastPoint;
                            if (newActualPoint == actualPoint) break;
                            else
                            {
                                src[newActualPoint.X, newActualPoint.Y] = configuration.ViejoLimite;
                                pointsOfPath.Add(newActualPoint);
                            }
                        }
                        shapeList.Add(new Shape(pointsOfPath));
                    }
                    lastPoint = actualPoint;
                }
            }
            return shapeList;
        }

        private static (Point newActualPoint, Point newLastPoint) GetNextPoint(Point actualPoint, Point lastPoint, Color[,] src, ColorConfiguration configuration)
        {
            var bounds = new Rectangle(Point.Empty, new Size(src.GetLength(0), src.GetLength(1)));
            if (!IsOutOfBounds(bounds, lastPoint) && src[lastPoint.X, lastPoint.Y] != configuration.Fondo) throw new Exception("Last Point Malo");
            var colliders = GetColliders(actualPoint, actualPoint.GetCardinal(lastPoint), true);
            for (int i = 1; i < 8; i++)
            {
                var actualCollider = colliders[i];
                var lastCollider = colliders[i - 1];
                if (!IsOutOfBounds(bounds, actualCollider) &&
                    (src[actualCollider.X, actualCollider.Y] == configuration.Limite || src[actualCollider.X, actualCollider.Y] == configuration.ViejoLimite))
                {
                    return (actualCollider, lastCollider);
                }
            }
            return (actualPoint, lastPoint);
        }

        private static bool IsOutOfBounds(Rectangle bounds, Point item)
        {
            return (item.X < bounds.Left || item.X >= bounds.Right) ||
                   (item.Y < bounds.Top || item.Y >= bounds.Bottom);
        }

        private static Point[] GetColliders(Point point, Cardinal from, bool fullColliders)
        {
            if (fullColliders) return new Point[]
            {
                point.Get((Cardinal)(((int)from+0)%8)),
                point.Get((Cardinal)(((int)from+1)%8)),
                point.Get((Cardinal)(((int)from+2)%8)),
                point.Get((Cardinal)(((int)from+3)%8)),
                point.Get((Cardinal)(((int)from+4)%8)),
                point.Get((Cardinal)(((int)from+5)%8)),
                point.Get((Cardinal)(((int)from+6)%8)),
                point.Get((Cardinal)(((int)from+7)%8))
            };
            else return new Point[]
            {
                point.Get((Cardinal)(((int)from+0)%8)),
                point.Get((Cardinal)(((int)from+2)%8)),
                point.Get((Cardinal)(((int)from+4)%8)),
                point.Get((Cardinal)(((int)from+6)%8)),
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

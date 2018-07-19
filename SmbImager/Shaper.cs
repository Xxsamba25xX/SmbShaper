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
			Color[,] result = new Color[src.GetLength(0), src.GetLength(1)];
			Rectangle bound = new Rectangle(Point.Empty, new Size(src.GetLength(0), src.GetLength(1)));
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
						bool inCollision = false;
						var colliders = GetColliders(new Point(i, j), false);
						foreach (var item in colliders)
						{
							//si colinda con el fondo setearlo de color borde
							if (IsOutOfBound(item, bound) || IsBackgroundColor(src[item.X, item.Y], backgroundColors))
							{
								result[i, j] = configuration.Limite;
								inCollision = true;
								break;
							}
						}
						//si no colinda con fondo setearlo de color relleno
						if(!inCollision)result[i, j] = configuration.Relleno;
					}
				}
			}
			return result;
		}

		private static bool IsOutOfBound(Point item, Rectangle bound)
		{
			return (item.X >= bound.Right) ||
				(item.X < bound.Left) ||
				(item.Y >= bound.Bottom) ||
				(item.Y < bound.Top);
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

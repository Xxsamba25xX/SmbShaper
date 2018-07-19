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
						foreach (var item in colliders)
						{
							//si colinda con el fondo setearlo de color borde
							if (IsBackgroundColor(src[item.X, item.Y], backgroundColors))
							{
								result[i, j] = configuration.Limite;
								break;
							}
						}
						//si no colinda con fondo setearlo de color relleno
						result[i, j] = configuration.Relleno;
					}
				}
			}
			return result;
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

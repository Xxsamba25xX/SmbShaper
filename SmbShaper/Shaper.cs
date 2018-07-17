using SmbShaper.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace SmbShaper
{
	public static class Shaper
	{
		public static Color[,] Normalize(Color[,] src, Color[] BackgroundColors, ColorConfiguration configuration)
		{
			for (int i = 0; i < src.GetLength(0); i++)
			{
				for (int j = 0; j < src.GetLength(1); j++)
				{
					bool isBackgroundColor = false;
					for (int k = 0; k < BackgroundColors.Length; k++)
					{
						isBackgroundColor = src[i, j] == BackgroundColors[k];
						if (isBackgroundColor) break;
					}
					
				}
			}
		}
	}
}

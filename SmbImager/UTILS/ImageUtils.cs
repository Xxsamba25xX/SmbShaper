using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SmbImager.UTILS
{
	public static class ImageUtils
	{

		public static Color[,] GetColors(Bitmap bitmap)
		{
			var bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat);

			IntPtr ptr = bitmapData.Scan0;

			// Declare an array to hold the bytes of the bitmap.
			int bytes = Math.Abs(bitmapData.Stride) * bitmap.Height;
			byte[] rgbaValues = new byte[bytes];
			int bpp = bitmapData.Stride / bitmap.Width;

			// Copy the RGB values into the array.
			System.Runtime.InteropServices.Marshal.Copy(ptr, rgbaValues, 0, bytes);

			// Unlock the bits.
			bitmap.UnlockBits(bitmapData);
			Color[,] result = new Color[bitmap.Width, bitmap.Height];
			int index = 0;
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int j = 0; j < bitmap.Width; j++)
				{
					if (bpp == 4)
						result[j, i] = Color.FromArgb(rgbaValues[index + 3], rgbaValues[index + 2], rgbaValues[index + 1], rgbaValues[index + 0]);
					if (bpp == 3)
						result[j, i] = Color.FromArgb(rgbaValues[index + 2], rgbaValues[index + 1], rgbaValues[index + 0]);
					index += bpp;
				}
			}
			return result;
		}

		public static Bitmap CreateBitmap(Color[,] colors)
		{
			Bitmap bitmap = new Bitmap(colors.GetLength(0), colors.GetLength(1));

			var bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat);

			IntPtr ptr = bitmapData.Scan0;

			// Declare an array to hold the bytes of the bitmap.
			int bytes = Math.Abs(bitmapData.Stride) * bitmap.Height;
			byte[] rgbaValues = new byte[bytes];
			int bpp = bitmapData.Stride / bitmap.Width;

			int index = 0;
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					if (bpp == 4)
						rgbaValues[index + 3] = colors[x, y].A;
					rgbaValues[index + 2] = colors[x, y].R;
					rgbaValues[index + 1] = colors[x, y].G;
					rgbaValues[index + 0] = colors[x, y].B;

					index += bpp;
				}
			}

			//Copies the rgbValues to the bitmap
			System.Runtime.InteropServices.Marshal.Copy(rgbaValues, 0, ptr, bytes);

			// Unlock the bits.
			bitmap.UnlockBits(bitmapData);
			return bitmap;
		}
	}
}

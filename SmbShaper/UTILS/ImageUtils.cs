using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SmbShaper.UTILS
{
	public static class ImageUtils
	{
		public static Color[,] GetColors(Bitmap bitmap)
		{
			var bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Canonical);

			IntPtr ptr = bitmapData.Scan0;

			// Declare an array to hold the bytes of the bitmap.
			int bytes = Math.Abs(bitmapData.Stride) * bitmap.Height;
			byte[] rgbaValues = new byte[bytes];

			// Copy the RGB values into the array.
			System.Runtime.InteropServices.Marshal.Copy(ptr, rgbaValues, 0, bytes);

			// Unlock the bits.
			bitmap.UnlockBits(bitmapData);

			return null;
		}
	}
}

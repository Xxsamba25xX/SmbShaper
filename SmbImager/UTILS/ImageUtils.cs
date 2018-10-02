using System;
using System.Drawing;

namespace SmbImager.UTILS
{
   public static class ImageUtils
   {

      public static Color[,] GetColors(Bitmap bitmap)
      {
         var width = bitmap.Width;
         var height = bitmap.Height;
         Color[,] result = new Color[width, height];
         byte[] rgbaValues = null;
         int bpp = 0;
         lock (bitmap)
         {
            var bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat);

            IntPtr ptr = bitmapData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bitmapData.Stride) * height;
            rgbaValues = new byte[bytes];
            bpp = bitmapData.Stride / width;

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbaValues, 0, bytes);

            // Unlock the bits.
            bitmap.UnlockBits(bitmapData);
         }
         int index = 0;
         for (int i = 0; i < height; i++)
         {
            for (int j = 0; j < width; j++)
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
         var width = bitmap.Width;
         var height = bitmap.Height;

         var bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat);

         IntPtr ptr = bitmapData.Scan0;

         // Declare an array to hold the bytes of the bitmap.
         int bytes = Math.Abs(bitmapData.Stride) * height;
         byte[] rgbaValues = new byte[bytes];
         int bpp = bitmapData.Stride / width;

         int index = 0;
         for (int y = 0; y < height; y++)
         {
            for (int x = 0; x < width; x++)
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

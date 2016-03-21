using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterpolateImagine
{
    class InterpolateImagine
    {
        static void Main(string[] args)
        {
            Bitmap myBmp = (Bitmap)Image.FromFile("tiger.bmp");
            int width = 640;
            int height = 480;

            ResampleImagine(myBmp, new Size(width, height), "NewSizeTiger.bmp");
        }

        static void ResampleImagine(Bitmap bmp, Size newSize, string savePath)
        {
            Bitmap newBmp = new Bitmap(newSize.Width, newSize.Height);

            int bmpX = bmp.Width;
            int bmpY = bmp.Height;
            int newBmpX = newBmp.Width;
            int newBmpY = newBmp.Height;
            
            float ratioX =  (float) bmpX / (float)newBmpX;
            float ratioY = (float) bmpY / (float)newBmpY;

            for (int i = 0; i < newBmp.Width; i++)
            {
                for (int j = 0; j < newBmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel((int)(ratioX * i), (int)(ratioY * j));
                    newBmp.SetPixel(i, j, pixel);
                }
            }
            newBmp.Save(savePath);
        }
    }
}

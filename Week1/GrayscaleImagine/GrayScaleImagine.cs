using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayscaleImagine
{
    class GrayScaleImagine
    {
        static void Main(string[] args)
        {
            Bitmap myBmp = (Bitmap)Image.FromFile("tiger.bmp");
            GrayImagine(myBmp, "NewTiger.bmp");
        }

        static void GrayImagine(Bitmap bmp, string savePath)
        {
            Bitmap gray = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color oldColor = bmp.GetPixel(i, j);
                    int grayScale = (int)((oldColor.R * 0.27) + (oldColor.G * 0.58) + (oldColor.B * 0.15));

                    Color newColor = Color.FromArgb(oldColor.A, grayScale, grayScale, grayScale);
                    gray.SetPixel(i, j, newColor);
                }
            }
            gray.Save(savePath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ApplyALinerFilter
{
    class ApplayALinerFilter
    {
        static void Main(string[] args)
        {
            Bitmap myBmp = (Bitmap)Image.FromFile("tiger.bmp");
            BlurImage(myBmp, "blurTiger.bmp");
        }

        static void BlurImage(Bitmap bitmap, string savePath)
        {
            Bitmap blurBmp = new Bitmap(bitmap.Width, bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int newA = 0;
                    int newR = 0;
                    int newG = 0;
                    int newB = 0;
                    int counter = 0;
                    

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (x + i > 0 && x + i < (bitmap.Width - 1) && y + j > 0 && y + j < (bitmap.Height - 1))
                            {
                                Color pixel = bitmap.GetPixel(x + i, y + j);
                                newA += pixel.A;
                                newR += pixel.R;
                                newG += pixel.G;
                                newB += pixel.B;
                                counter++;

                            }
                        }
                    }

                    newA = (int)Math.Round((double)newA / counter);
                    newR = (int)Math.Round((double)newR / counter);
                    newG = (int)Math.Round((double)newG / counter);
                    newB = (int)Math.Round((double)newB / counter);

                    Color newColor = Color.FromArgb(newA, newR, newG, newB);
                    blurBmp.SetPixel(x, y, newColor);
                }
            }
            blurBmp.Save(savePath);
        }

    }
}

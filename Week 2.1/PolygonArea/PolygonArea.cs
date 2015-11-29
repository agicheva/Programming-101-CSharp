using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PolygonArea
{
    class PolygonArea
    {
        static void Main(string[] args)
        {
            PointF[] polygonPoints = new PointF[]
            {
                new PointF((float)1.0, (float)1.0),
                new PointF((float)2.0, (float)2.0),
                new PointF((float)0.0, (float)3.0),
                new PointF((float)0.0, (float)0.0),
            };

            Console.WriteLine(CalcArea(polygonPoints));
        }

        static float CalcArea(PointF[] points)
        {
            float area = 0.0f;

            for (int i = 0; i < points.Length; i++)
            {
                if (i == points.Length - 1)
                {
                    area += points[i].X * points[0].Y - points[0].X * points[i].Y;
                }

                else
                {
                    area += ((points[i].X * points[i + 1].Y) - (points[i + 1].X * points[i].Y));
                }
            }

            float polygonArea = area / 2;
            return polygonArea;
        }
    }
}

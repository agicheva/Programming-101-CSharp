using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigure
{
    class GeometryFigure
    {
        static void Main(string[] args)
        {
            Point A = new Point(3.0, 4.0);
            Point B = new Point(A);
            Point C = new Point(3.0, 5.0);
            Point D = new Point();

            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());
            Console.WriteLine(D.ToString());
            Console.WriteLine(A.Equals(B));
            Console.WriteLine(B.Equals(C));
            Console.WriteLine(A == B);
            Console.WriteLine(A == C);

            LineSegment line1 = new LineSegment(A, C);
            LineSegment line2 = new LineSegment(D, A);

            Console.WriteLine(line1.Equals(line2));
            Console.WriteLine(line1 == line2);
            Console.WriteLine(line1.ToString());
            Console.WriteLine(line1 > line2);
            Console.WriteLine(line2 >= 3.0);

            Point left = new Point(1, 1);
            Point right = new Point(7, 5);
            Point c = new Point(4, 3);

            Rectangle rect1 = new Rectangle(left, right);
            Rectangle rect2 = new Rectangle(c, right);
            Rectangle rect3 = new Rectangle(rect1);

            Console.WriteLine(rect3.ToString());
            Console.WriteLine(rect1.GetPerimeter());
            Console.WriteLine(rect1.GetArea());
            Console.WriteLine(rect1.Equals(rect2));
            Console.WriteLine(rect1.Equals(rect3));
            Console.WriteLine(rect1.Center.ToString());
            Console.WriteLine(rect1 == rect2);
            Console.WriteLine(rect2 != rect3);

            Vector v1 = new Vector(1, 3, 5);
            Vector v2 = new Vector(2, 4, 6);
            Vector v3 = new Vector(v1);
            double num = 5;

            Console.WriteLine(v1.ToString());
            Console.WriteLine(v1.Equals(v2));
            Console.WriteLine(v1.Equals(v3));
            Console.WriteLine((v1 + v2).ToString());
            Console.WriteLine((v2 - v1).ToString());
            Console.WriteLine((v1 * v2).ToString());
            Console.WriteLine((v1 / v2).ToString());
            Console.WriteLine((v1 + num).ToString());
        }
    }
}

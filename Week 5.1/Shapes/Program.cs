using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point centreRect = new Point(1, 1);
            Point centreSquare = new Point(0, 0);
            
            Rectangle rect = new Rectangle(3, 5, centreRect);
            Square square = new Square(2, centreSquare);
            Ellipse ellipse = new Ellipse(2, 1, centreSquare);

            Console.WriteLine(rect.ToString());
            Console.WriteLine(rect.GetArea() + " " + rect.GetPerimeter());

            Console.WriteLine(square.ToString());
            Console.WriteLine(square.GetArea() + " " + square.GetPerimeter());

            Console.WriteLine(ellipse.ToString());
            Console.WriteLine(ellipse.GetArea() + " " + ellipse.GetPerimeter());
        }
    }
}

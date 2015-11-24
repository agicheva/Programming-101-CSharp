using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InflateARectangle
{
    class InflateARectangle
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(new Point(0,0), new Size(10,10));
            Inflate(ref rectangle, new Size(2, 2));

            Console.WriteLine(rectangle);
        }

        static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
            rect.Width += 2 * inflateSize.Width;
            rect.Height += 2 * inflateSize.Height;
        }
    }
}

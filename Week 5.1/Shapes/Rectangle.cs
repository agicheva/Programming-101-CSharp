using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double width;
        private double height;
        private Point centre;

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public Point Centre
        {
            get
            {
                return centre;
            }

            protected set
            {
                centre = value;
            }
        }

        public Rectangle(double width, double height, Point centre)
        {
            this.width = width;
            this.height = height;
            this.centre = new Point(centre);
        }

        public override double GetArea()
        {
            double area = width * height;
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = (2 * width) + (2 * height);
            return perimeter;
        }

        public override string ToString()
        {
            string str = string.Format("Rectangle has {0} width and {1} height with centre {2}", width, height, centre);
            return str;
        }
    }
}

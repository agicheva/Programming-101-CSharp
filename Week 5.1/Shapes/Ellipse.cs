using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Ellipse : Shape
    {
        private double radiusX;
        private double radiusY;
        private Point centre;

        public double RadiusX
        {
            get
            {
                return radiusX;
            }

            set
            {
                radiusX = value;
            }
        }

        public double RadiusY
        {
            get
            {
                return radiusY;
            }

            set
            {
                radiusY = value;
            }
        }

        public Point Centre
        {
            get
            {
                return centre;
            }

            set
            {
                centre = value;
            }
        }

        public Ellipse(double radiusX, double radiusY, Point centre)
        {
            this.radiusX = radiusX;
            this.radiusY = radiusY;
            this.centre = new Point(centre.X, centre.Y);
        }

        public override double GetArea()
        {
            double area = Math.PI * radiusX * radiusY;
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = 2 * Math.PI * Math.Sqrt(((radiusX * radiusX) + (radiusY * radiusY)) / 2);
            return perimeter;
        }

        public override string ToString()
        {
            string stringFormat = string.Format("Ellipse[radiusX: {0}, radiusY: {1}, centre: {2}]", radiusX, radiusY, centre);
            return stringFormat;
        }
    }
}

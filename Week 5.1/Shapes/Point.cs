using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Point
    {
        private readonly double x;
        private readonly double y;

        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }

        public override string ToString()
        {
            string format = string.Format("Point({0}, {1})", x, y);

            return format;
        }

        public override bool Equals(object obj)
        {
            Point point = (Point)obj;

            if (x == point.x && y == point.y)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator ==(Point first, Point second)
        {
            if (first.x == second.x && first.y == second.y)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Point first, Point second)
        {
            if (!first.Equals(second))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
    }
}

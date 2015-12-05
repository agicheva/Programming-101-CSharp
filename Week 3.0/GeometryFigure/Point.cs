using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigure
{
    class Point
    {
        private readonly double x;
        private readonly double y;
        private static readonly Point startDefault = new Point(0, 0);

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

        //Default point(the start of coordinate system
        //public static readonly Point Default = new Point(0, 0);
        private static Point _default = new Point(0, 0);
        public static Point Default
        {
            get
            {
                return _default;
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //CopyConstructor
        public Point(Point previousPoint)
        {
            x = previousPoint.x;
            y = previousPoint.y;
        }

        //when put "readonly" - boom
        public static Point PointOrigin()
        {
            return _default;
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

        public static bool operator==(Point first, Point second)
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

        public static LineSegment operator+(Point first, Point second)
        {
            LineSegment line = new LineSegment(first, second);
            return line;
        }
    }
}

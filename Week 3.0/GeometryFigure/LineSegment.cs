using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigure
{
    class LineSegment
    {
        private readonly Point a;
        private readonly Point b;

        public Point A
        {
            get
            {
                return a;
            }
        }

        public Point B
        {
            get
            {
                return b;
            }
        }

        public LineSegment()
        {

        }

        public LineSegment(Point a, Point b)
        { 
            if (a.Equals(b))
            {
                throw new ArgumentException("Cannot create a line segment with zero length");
            }

            this.a = a;
            this.b = b;
        }

        public LineSegment(LineSegment previousLine)
        {
            a = previousLine.a;
            b = previousLine.b;
        }

        public double GetLength()
        {
            double length;
            if (a.X == b.X)
            {
                length = Math.Abs(a.Y - b.Y);
                return length;
            }
            else if (a.Y == b.Y)
            {
                length = Math.Abs(a.X - b.X);
                return length;
            }
            else
            {
                length = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
                return length;
            }
        }

        public override string ToString()
        {
            string format = string.Format("Line:[({0}, {1}), ({2}, {3})]", a.X, a.Y, b.X, b.Y);
            return format;
        }

        public override bool Equals(object obj)
        {
            LineSegment line = (LineSegment)obj;
            if (line.a.Equals(a) && line.b.Equals(b))
            {
                return true;
            }
            return false;
        }

        public static bool operator==(LineSegment first, LineSegment second)
        {
            return Equals(first, second);
        }

        public static bool operator!=(LineSegment first, LineSegment second)
        {
            return !Equals(first, second);
        }

        public static bool operator<(LineSegment first, LineSegment second)
        {
            if (first.GetLength() < second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator>(LineSegment first, LineSegment second)
        {
            if (first.GetLength() > second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator<=(LineSegment first, LineSegment second)
        {
            if (first.GetLength() < second.GetLength() || first.GetLength() == second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator>=(LineSegment first, LineSegment second)
        {
            if (first.GetLength() > second.GetLength() || first.GetLength() == second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator<(LineSegment line, double length)
        {
            if (line.GetLength() < length)
            {
                return true;
            }
            return false;
        }

        public static bool operator>(LineSegment line, double length)
        {
            if (line.GetLength() > length)
            {
                return true;
            }
            return false;
        }

        public static bool operator<=(LineSegment line, double lenght)
        {
            if (line.GetLength() < lenght || line.GetLength() == lenght)
            {
                return true;
            }
            return false;
        }

        public static bool operator>=(LineSegment line, double length)
        {
            if (line.GetLength() > length || line.GetLength() == length)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + a.GetHashCode();
                hash = hash * 23 + b.GetHashCode();
                return hash;
            }
        }
    }
}

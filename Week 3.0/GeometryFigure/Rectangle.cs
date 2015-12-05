using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigure
{
    class Rectangle
    {
        private readonly Point downLeft;
        private readonly Point downRight;
        private readonly Point upLeft;
        private readonly Point upRight;

        private readonly LineSegment down;
        private readonly LineSegment up;
        private readonly LineSegment left;
        private readonly LineSegment right;

        private readonly double height;
        private readonly double width;
        private readonly Point center;

        public Point DownLeft
        {
            get
            {
                return downLeft;
            }
        }

        public Point DownRight
        {
            get
            {
                return downRight;
            }
        }

        public Point UpLeft
        {
            get
            {
                return upLeft;
            }
        }

        public Point UpRight
        {
            get
            {
                return upRight;
            }
        }

        public LineSegment Down
        {
            get
            {
                return down;
            }
        }

        public LineSegment Up
        {
            get
            {
                return up;
            }
        }

        public LineSegment Left
        {
            get
            {
                return left;
            }
        }

        public LineSegment Right
        {
            get
            {
                return right;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
        }

        public Point Center
        {
            get
            {
                return center;
            }
        }

        public Rectangle()
        {

        }

        public Rectangle(Point leftPoint, Point rightPoint)
        {
            if (leftPoint.X == rightPoint.X || leftPoint.Y == rightPoint.Y)
            {
                throw new ArgumentException("Points are on the same axis.");
            }

            else
            {
                if (leftPoint.Y > rightPoint.Y)
                {
                    Point temp = leftPoint;
                    leftPoint = rightPoint;
                    rightPoint = temp;
                }

                width = rightPoint.X - leftPoint.X;
                height = rightPoint.Y - leftPoint.Y;

                downLeft = leftPoint;
                upLeft = new Point(leftPoint.X, rightPoint.Y - width);
                upRight = rightPoint;
                downRight = new Point(rightPoint.X, leftPoint.Y + width);

                down = new LineSegment(downLeft, downRight);
                up = new LineSegment(upLeft, upRight);
                left = new LineSegment(downLeft, upLeft);
                right = new LineSegment(downRight, upRight);

                center = new Point(leftPoint.X + (width / 2), leftPoint.Y + (height / 2));
            }
        }

        public Rectangle(Rectangle previousRectangle)
        {
            width = previousRectangle.width;
            height = previousRectangle.height;

            downLeft = new Point(previousRectangle.downLeft);
            downRight = new Point(previousRectangle.downRight);
            upLeft = new Point(previousRectangle.upLeft);
            upRight = new Point(previousRectangle.upRight);

            down = new LineSegment(previousRectangle.down);
            up = new LineSegment(previousRectangle.up);
            left = new LineSegment(previousRectangle.left);
            right = new LineSegment(previousRectangle.right);

            center = new Point(previousRectangle.center);
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }

        public double GetArea()
        {
            return width * height;
        }

        public override string ToString()
        {
            string format = string.Format("Rectangle[({0}, {1}), ({2}, {3})]", downLeft.X, downLeft.Y, height, width);
            return format;
        }

        public override bool Equals(object obj)
        {
            Rectangle rect = (Rectangle)obj;

            if (downLeft.Equals(rect.downLeft) && downRight.Equals(rect.downRight) &&
                upLeft.Equals(rect.upLeft) && upRight.Equals(rect.upRight))
            {
                return true;
            }
            return false;
        }

        public static bool operator==(Rectangle first, Rectangle second)
        {
            if (first.Equals(second))
            {
                return true;
            }
            return false;
        }

        public static bool operator!=(Rectangle first, Rectangle second)
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
                int hash = 13;
                hash = hash * 7 + downLeft.GetHashCode();
                hash = hash * 7 + downRight.GetHashCode();
                hash = hash * 7 + upLeft.GetHashCode();
                hash = hash * 7 + upRight.GetHashCode();

                hash = hash * 7 + down.GetHashCode();
                hash = hash * 7 + up.GetHashCode();
                hash = hash * 7 + left.GetHashCode();
                hash = hash * 7 + right.GetHashCode();

                hash = hash * 7 + width.GetHashCode();
                hash = hash * 7 + height.GetHashCode();
                hash = hash * 7 + center.GetHashCode();
                return hash;
            }
        }
    }
}

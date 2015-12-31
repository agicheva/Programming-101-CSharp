using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
                Width = value;
                Heigth = value;
            }
        }

        public Square(double side, Point centre) : base(side, side, centre)
        {
            this.side = side;
        }

        public override string ToString()
        {
            string str = string.Format("Square with side {0} and centre {1}", side, Centre);
            return str;
        }
    }
}

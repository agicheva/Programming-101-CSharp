using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Toy
    {
        public string Type
        {
            get;
            protected set;
        }

        public string Color
        {
            get;
            protected set;
        }

        public string Size
        {
            get;
            protected set;
        }

        public Toy(string type, string color, string size)
        {
            Type = type;
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}, which is {1} with {2} color", Type, Size, Color);
            return str.ToString();
        }
    }
}

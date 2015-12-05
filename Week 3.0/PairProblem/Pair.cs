using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProblem
{
    class Pair
    {
        private object first;
        private object second;

        public object First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public object Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public Pair()
        {

        }

        public Pair(object first, object second)
        {
            this.first = first;
            this.second = second;
        }

        public override string ToString()
        {
            string format = string.Format("{0}, {1}", first, second); 
            
            return format;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair)obj;

            if (pair.first.Equals(first) && pair.second.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator==(Pair a, Pair b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }

        public static bool operator!=(Pair a, Pair b)
        {
            if (!a.Equals(b))
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
                hash = hash * 23 + first.GetHashCode();
                hash = hash * 23 + second.GetHashCode();

                return hash;
            }
        }
    }
}

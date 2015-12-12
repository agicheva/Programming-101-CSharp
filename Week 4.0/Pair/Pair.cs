using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProblem
{
    class Pair<T1, T2>
    {
        private T1 first;
        private T2 second;

        public T1 First
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

        public T2 Second
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

        public Pair(T1 first, T2 second)
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
            Pair<T1, T2> pair = (Pair<T1, T2>)obj;

            if (pair.first.Equals(first) && pair.second.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pair<T1, T2> a, Pair<T1, T2> b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pair<T1, T2>a, Pair<T1, T2> b)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, int> p = new Pair<int, int>(2, 3);
            Pair<int, int> p1 = new Pair<int, int>(4, 5);
            Pair<int, int> p2 = new Pair<int, int>(2, 3);

            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(p1));

            if (p == p2)
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

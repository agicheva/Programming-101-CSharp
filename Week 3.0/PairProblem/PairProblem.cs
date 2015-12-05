using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProblem
{
    class PairProblem
    {
        static void Main(string[] args)
        {
            Pair p = new Pair(2, 3);
            Pair p1 = new Pair(4, 5);
            Pair p2 = new Pair(2, 3);

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

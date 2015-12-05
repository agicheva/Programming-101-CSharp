using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsProblem
{
    class FractionsProblem
    {
        static void Main(string[] args)
        {
            Fractions fraction = new Fractions(1, 4);
            Fractions fraction1 = new Fractions(1, 5);
            double doubleFraction = 0.5;

            Console.WriteLine(fraction.ToString());
            Console.WriteLine(fraction.Equals(fraction1));

            Fractions sum = fraction + fraction1;
            Fractions odd = fraction - fraction1;
            Fractions mult = fraction * fraction1;
            Fractions devide = fraction / fraction1;
            Console.WriteLine(sum);
            Console.WriteLine(odd);
            Console.WriteLine(mult);
            Console.WriteLine(devide);

            double dSum = fraction + doubleFraction;
            double dOdd = fraction - doubleFraction;
            double dMult = fraction * doubleFraction;
            double dDevide = fraction / doubleFraction;
            Console.WriteLine(dSum);
            Console.WriteLine(dOdd);
            Console.WriteLine(dMult);
            Console.WriteLine(dDevide);
        }
    }
}

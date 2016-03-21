using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int product = 1;

            if (num == 0)
            {
                Console.WriteLine(1);
                return;
            }

            for (int i = 1; i <= num; i++)
            {
                product *= i;
            }
        
            Console.WriteLine(product);

            Console.WriteLine(Fac(6));
        }

        static int Fac(int input)
        {
            int temp;

            if (input == 0)
            {
                return 1;
            }

            temp = input * Fac(input - 1);
            return  temp;
        }
    }
}

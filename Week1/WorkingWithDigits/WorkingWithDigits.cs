using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDigits
{
    class WorkingWithDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(145));
            Console.WriteLine(CountDigits(145));
            Console.WriteLine(FactorialDigits(145));
        }

        static int CountDigits(int input)
        {
            string newInt = input.ToString();
            return newInt.Length;
        }

        static int SumDigits(int input)
        {
            
            int temp = 0;
            int digits = CountDigits(input);
            for (int i = 0; i < digits; i++)
            {
                temp += input % 10;
                input /= 10;   
            }

            return temp;
        }

        static int Fac(int input)
        {
            int temp;

            if (input == 0)
            {
                return 1;
            }

            temp = input * Fac(input - 1);
            return temp;
        }

        static int FactorialDigits(int input)
        {
            int sum = 0;
            int digits = CountDigits(input);
            for (int i = 0; i < digits; i++)
            {
                sum += Fac(input % 10);
                input /= 10;
            }
            return sum;
        }





    }
}

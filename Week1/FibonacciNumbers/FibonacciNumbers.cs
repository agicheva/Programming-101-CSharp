using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int myInput = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(myInput));

            long[] firstNFibNums = new long[myInput];

            for (int i = 0; i < firstNFibNums.Length; i++)
            {
                firstNFibNums[i] = Fib(i);
            }

            for (int i = 0; i < firstNFibNums.Length; i++)
            {
                Console.Write(firstNFibNums[i]);
            }
            Console.WriteLine();
        }
        
        static long Fib(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else if (input == 0)
            {
                return 0;
            }
            var first = Fib(input - 1);
            var second = Fib(input - 2);

            return first + second;
        }
    }
}

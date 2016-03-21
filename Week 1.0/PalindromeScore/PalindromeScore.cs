using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeScore
{
    class PalindromeScore
    {
        static void Main(string[] args)
        {
            int myInput = int.Parse(Console.ReadLine());

            Console.WriteLine(pScore(myInput));
        }

        static int pScore(int input)
        {
            bool isPalindrome = true;
            string str = input.ToString();
            int result = input;
            List<int> rNumbers = new List<int>();
            List<int> numbers = new List<int>();
                
            while (result > 0)
            {
                rNumbers.Add(result % 10);
                result /= 10;
            }

            numbers = rNumbers.Reverse<int>().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (rNumbers[i] != numbers[i])
                {
                    isPalindrome = false;
                }
            }


            int sizeReversed = rNumbers.Count;
            int sumReversed = 0;

            for (int i = 0; i < sizeReversed; i++)
            {
                sumReversed += (int)(Math.Pow(10, sizeReversed - i - 1) * rNumbers[i]);
            }

            if (isPalindrome)
            {
                return 1;
            }

            else
            {
                return 1 + pScore(input + sumReversed); 
            }
        }
    }
}

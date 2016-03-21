using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPalindrome
{
    class IntegerPalindrome
    {
        static void Main(string[] args)
        {
            int myInteger = int.Parse(Console.ReadLine());
            Console.WriteLine(IsIntPalindrome(myInteger));
            Console.WriteLine(GetLargestPalindrome(myInteger));

        }

        static bool IsIntPalindrome(int input)
        {

            bool isIntPalindrome = true;
            string str = input.ToString();
            int result = input;
            List<int> numbers = new List<int>();
            List<int> reversedNumbers = new List<int>();

            while (result > 0)
            {
                numbers.Add(result % 10);
                result /= 10;
            }

            reversedNumbers = numbers.Reverse<int>().ToList();

            for (int i = 0; i < reversedNumbers.Count; i++)
            {
                if (numbers[i] != reversedNumbers[i])
                {
                    isIntPalindrome = false;
                }
            }
            return isIntPalindrome;
        }

        static int GetLargestPalindrome(int input)
        {
            if (IsIntPalindrome(input))
            {
                return input;
            }

            for (int i = input - 1; i >= 0; i--)
            {
                if (IsIntPalindrome(i))
                {
                    return i;
                }
            }
            return 1;

        }

    }
}

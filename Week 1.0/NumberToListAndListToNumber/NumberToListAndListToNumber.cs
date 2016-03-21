using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToListAndListToNumber
{
    class NumberToListAndListToNumber
    {
        static void Main(string[] args)
        {
            List<int> list = NumberToList(179);
            
            Console.WriteLine( NumberToList(167));
        }

        static List<int> NumberToList(int number)
        {
            List<int> numbers = new List<int>();
            string str = number.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                numbers.Add(number % 10);
                number /= 10;
            }
            
            numbers.Reverse();
            return numbers;
        }

        static int ListToNumber(List<int> digits)
        {
            int size = digits.Count;
            int sum = 0;


            for (int i = 0; i < size; i++)
            {
                sum += (int)(Math.Pow(10, size - i - 1) * digits[i]);
            }
            return sum;
        }
    }
}

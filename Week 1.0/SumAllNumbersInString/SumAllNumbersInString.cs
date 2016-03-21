using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAllNumbersInString
{
    class SumAllNumbersInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOFIntegers("123abc45de6"));
            Console.WriteLine(SumOFIntegers("abcd"));
        }

        static int SumOFIntegers(string str)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string[] splittedStr = str.Split(alphabet, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int[] nums = new int[splittedStr.Length];

            for (int i = 0; i < splittedStr.Length; i++)
            {
                sum += int.Parse(splittedStr[i]);
            }
            return sum;
        }
    }
}

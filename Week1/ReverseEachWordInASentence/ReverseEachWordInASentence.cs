using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordInASentence
{
    class ReverseEachWordInASentence
    {
        static void Main(string[] args)
        {
            string myString = "How are you?";
            Console.WriteLine(ReverseSenetence(myString));

        }

        static string ReverseSenetence(string str)
        {
            string[] arr = str.Split(' ');
            List<string> reversed = new List<string>();

            for (int i = arr.Length - 1; i > -1; i--)
            {
                reversed.Add(arr[i]);
            }

            string reversedStr = string.Join(" ", reversed.ToArray());

            return reversedStr;
        }
    }
}

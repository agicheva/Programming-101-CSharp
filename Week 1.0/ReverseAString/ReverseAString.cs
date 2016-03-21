using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class ReverseAString
    {
        static void Main(string[] args)
        {
            string input = "Ani";
            Console.Write(ReverseStr(input));
            Console.WriteLine();
        }

        static string ReverseStr(string originalString)
        {
            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

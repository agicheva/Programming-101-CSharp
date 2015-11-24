using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAnURL
{
    class DecodeAnURL
    {
        static void Main(string[] args)
        {
            string input = "kitten%20pic.jpg";
            Console.WriteLine(Decode(input));

        }

        static string Decode(string input)
        {
            string output = input;

            input = input.Replace("%20", " ");
            input = input.Replace("%3A", ":");
            input = input.Replace("%3D", "?");
            input = input.Replace("%2F", "/");

            return input;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInAString
{
    class VowelsInAString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountVowels("Theistareykjarbunga"));
        }

        static int CountVowels(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y' || str[i] == ' ')
                {
                    counter++;
                }
                else
                {
                    continue;
                }

            }

            return counter;
        }
    }
}

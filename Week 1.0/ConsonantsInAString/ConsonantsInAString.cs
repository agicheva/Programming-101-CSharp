using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonantsInAString
{
    class ConsonantsInAString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountConsonants("Theistareykjarbunga"));
        }

        static int CountConsonants(string str)
        {
            int counter = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y' || str[i] == ' ')
                {
                    continue;
                }
                else
                {
                    counter++;
                }

            }

            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharHistogram
{
    class CharHistogram
    {
        static Dictionary<char, int> dictionaries = new Dictionary<char, int>();
        static void Main(string[] args)
        {
            string str1 = "Anniiiiii.";
            
            CharHis(str1).ToList().ForEach(x => Console.WriteLine("{0} - {1}", x.Key, x.Value));
            
        }

        static Dictionary<char, int> CharHis(string str)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!dictionaries.ContainsKey(str[i]))
                {
                    dictionaries.Add(str[i], CoutLetter(str[i], str));
                }
            }

            return dictionaries;
        }
        
        static int CoutLetter(char letter, string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}

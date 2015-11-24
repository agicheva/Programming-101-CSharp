using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            Console.WriteLine(IsAnagram(firstInput, secondInput));
        }

        static bool IsAnagram(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }

            var charHistogramFirst = CharHis(first);
            var charHistogramSecond = CharHis(second);

            if (charHistogramFirst.Count != charHistogramSecond.Count)
            {
                return false;
            }

            foreach (KeyValuePair<char, int> pair in charHistogramFirst)
            {

                if (charHistogramSecond.ContainsKey(pair.Key))
                {
                    if (charHistogramSecond[pair.Key] != pair.Value)
                    {
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                

            }
            return true;
        }

        static Dictionary<char, int> CharHis(string str)
        {
            Dictionary<char, int> dictionaries = new Dictionary<char, int>();

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

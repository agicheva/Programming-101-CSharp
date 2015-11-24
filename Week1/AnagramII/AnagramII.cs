using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramII
{
    class AnagramII
    {
        static void Main(string[] args)
        {
            string str1 = "string";
            string str2 = "gnirts";
            string str3 = "strink";
            string str4 = "arstringtrew";

            Console.WriteLine(Anagram(str1, str2));
            Console.WriteLine(Anagram(str1, str3));
            Console.WriteLine(Subsequence.HasAnagram(str1, str4));
        }

        public static bool Anagram(string first, string second)
        {
            
            List<char> charFirst = new List<char>();
            List<char> charSecond = new List<char>();
            

            if (first.Length != second.Length)
            {
                return false;
            }

            for (int i = 0; i < first.Length; i++)
            {
                charFirst.Add(first[i]);
            }

            for (int i = 0; i < second.Length; i++)
            {
                charSecond.Add(second[i]);
            }

            for (int i = 0; i < charFirst.Count; i++)
            {
                if (CountChar(charFirst, charFirst[i]) != CountChar(charSecond, charFirst[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static int CountChar(List<char> list, char ch)
        {
            int counter = 0; 
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == ch)
                {
                    counter++;
                }
            }

            return counter;
        }


    }
}

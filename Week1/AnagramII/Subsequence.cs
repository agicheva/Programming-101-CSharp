using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramII
{
    class Subsequence
    {
        public static bool HasAnagram(string first, string second)
        {
            List<char> charFirst = new List<char>();
            List<char> charSecond = new List<char>();
            List<char> sub = new List<char>();

            for (int i = 0; i < first.Length; i++)
            {
                charFirst.Add(first[i]);
            }

            for (int i = 0; i < second.Length; i++)
            {
                charSecond.Add(second[i]);
            }

            for (int i = 0; i < charSecond.Count - charFirst.Count; i++)
            {
                sub = charSecond.GetRange(i, charFirst.Count);
                string subStr = string.Join("", sub.ToArray());
                if (AnagramII.Anagram(first, subStr))
                {
                    return true;
                }
                
            }

            return false;
        }

    }
}

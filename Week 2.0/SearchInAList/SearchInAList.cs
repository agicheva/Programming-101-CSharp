using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInAList
{
    class SearchInAList
    {
        static void Main(string[] args)
        {
            int foundIndex;
            List<string> input = new List<string>() { "How are you", "Fine thank you", "How about you" };
            Console.WriteLine(TryFindSubstring(input, "Fine", out foundIndex));
            Console.WriteLine(foundIndex);
        }

        static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(isSearched(list[i], searched))
                {   
                    foundIndex = i;
                    return true;
                }
                
            }
            foundIndex = -1;
            return false;

        }

        static bool isSearched(string str, string subStr)
        {
            bool search = str.Contains(subStr);
            return search;
        }
    }
}

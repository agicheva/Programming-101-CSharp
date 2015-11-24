using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyEachCharacterKTimes
{
    class CopyEachCharacterKTimes
    {
        static void Main(string[] args)
        {
            string str = "Ani";
            Console.Write(CopyEachChar(str, 3));
            Console.WriteLine();
        }

        static string CopyEachChar(string original, int k)
        {
            char[] array = original.ToCharArray();
            List<char> newArray = new List<char>();
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray = AddCHar(newArray, array[i], k);
            }
           
            string resultStr = string.Join("", newArray.ToArray());
            return resultStr;
        }

        static List<char> AddCHar(List<char> newArr, char ch, int k)
        {
            for (int i = 0; i < k; i++)
            {
                newArr.Add(ch);
            }
            return newArr;
        }
    }
}

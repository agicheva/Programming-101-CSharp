using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningString
{
    class JoiningString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JoinStr(" ", "Hello", "world", "C#"));
        }

        static string JoinStr(string separator, params string[] strings)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < strings.Length; i++)
            {
                if (i == 0)
                {
                    result.Append(strings[i]);
                    continue;
                }

                result.Append(" ");
                result.Append(strings[i]);
            }
            string strResult = result.ToString();
            return strResult;
        }
    }
}

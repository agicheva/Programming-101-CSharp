using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialGenerator
{
    class FatorialGenerator
    {
        static void Main(string[] args)
        {
            foreach (var item in GenerateFactorials(5))
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> GenerateFactorials(int n)
        {
            if (n <= 1)
                yield return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
                yield return result;
            }
            
        }
    }
}

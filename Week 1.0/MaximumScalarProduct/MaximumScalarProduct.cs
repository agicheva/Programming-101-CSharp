using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumScalarProduct
{
    class MaximumScalarProduct
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int>();
            List<int> second = new List<int>();

            first.Add(4);
            first.Add(10);
            first.Add(6);

            second.Add(6);
            second.Add(4);
            second.Add(10);
            Console.WriteLine(MaxProduct(first, second));
            
        }

        static int MaxProduct(List<int> first, List<int> second)
        {
            if (first.Count < second.Count)
            {
                for (int i = 0; i < second.Count - first.Count; i++)
                {
                    first.Add(0);
                }
            }

            else if (second.Count < first.Count)
            {
                for (int i = 0; i < first.Count - second.Count; i++)
                {
                    second.Add(0);
                }
            }

            first.Sort();
            second.Sort();
            int result = 0;
            

            for (int i = 0; i < first.Count; i++)
            {
                result += (first[i] * second[i]);
            }

            return result;
        }
        
    }
}

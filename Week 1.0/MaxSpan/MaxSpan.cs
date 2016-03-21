using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSpan
{
    class MaxSpan
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input.Add(1);
            input.Add(2);
            input.Add(1);
            input.Add(1);
            input.Add(3);

            Console.WriteLine(MSpan(input));

            List<int> input1 = new List<int>();
            input1.Add(1);
            input1.Add(4);
            input1.Add(6);
            input1.Add(1);
            input1.Add(4);
            input1.Add(4);
            input1.Add(6);
            input1.Add(7);
            input1.Add(8);
            input1.Add(8);
            input1.Add(9);
            input1.Add(6);

            Console.WriteLine(MSpan(input1));
        }

        static int MSpan(List<int> numbers)
        {
            if (numbers.Count == 1)
            {
                return 1;
            }

            int maxSpan = 0;
            int index = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                index = i;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        index = j;
                    }
                }

                if (maxSpan < index - i + 1)
                {
                    maxSpan = index - i + 1;
                }                
            }
            return maxSpan;
        }
    }
}

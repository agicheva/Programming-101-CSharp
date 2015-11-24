using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAList
{
    class ReverseAList
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void Reverse(List<int> list)
        {
            int temp;
            for (int i = 0; i < list.Count; i++)
            {
                temp = list[i];
                list[i] = list[list.Count - i -1];
                temp = list[list.Count - i - 1];
            }
        }
    }
}

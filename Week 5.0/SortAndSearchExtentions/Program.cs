using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearchExtentions
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>() { 2, 4, 1, 6, 10 };
            //IList<int> sorted = list.BubbleSort(new MyIntComparer());
            IList<int> sorted = list.SelectionSort(new MyIntComparer());
            int index = sorted.BinarySearch(6, new MyIntComparer());

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(index);
        }
    }
}

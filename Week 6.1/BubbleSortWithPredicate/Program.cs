using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortWithPredicate
{
    public delegate int ComparerDelegate(int x, int y);
    class Program
    {
        public static int Comparer(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }

            else if (x < y)
            {
                return -1;
            }
            return 0;
        }

        public static List<int> BubbleSort(List<int> list, ComparerDelegate comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (comparer(list[i], list[j]) == 1)
                    {
                        int temp;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 4, 2, 7, 9, 1, 5, 8, 3, 6 };

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ComparerDelegate comp = Comparer;
            BubbleSort(myList, comp);

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

        }
    }
}

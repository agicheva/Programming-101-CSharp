using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearchExtentions
{
    public static class SortAndSearchExtentions
    {
        public static IList<int> list { get; set; }

        public static IList<int> BubbleSort(this IList<int> list, MyIntComparer comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count - 1; j++)
                {
                    if (comparer.Compare(list[i], list[j]) == 1)
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

        public static IList<int> SelectionSort(this IList<int> list, MyIntComparer comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer.Compare(list[j], list[min]) == -1)
                    {
                        min = j;

                        int temp;
                        temp = list[i];
                        list[i] = list[min];
                        list[min] = temp;
                    }
                }
            }
            return list;
        }

        public static int BinarySearch(this IList<int> list, int searchedValue, MyIntComparer comparer)
        {
            int minIndex = 0;
            int maxIndex = list.Count - 1;
            int midIndex = (minIndex + maxIndex) / 2;

            while (minIndex <= maxIndex)
            {
                if (comparer.Compare(searchedValue, list[(minIndex + maxIndex) / 2]) == 0)
                {
                    return (minIndex + maxIndex) / 2;
                }

                if (comparer.Compare(searchedValue, list[(minIndex + maxIndex) / 2]) == -1)
                {
                    maxIndex = ((minIndex + maxIndex) / 2) - 1;
                }

                else
                {
                    minIndex = ((minIndex + maxIndex) / 2) + 1;
                }
            }
            return -1;
        }

    }
}

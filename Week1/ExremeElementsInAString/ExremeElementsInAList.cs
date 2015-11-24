using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExremeElementsInAString
{
    class ExremeElementsInAList
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 10, 11, 5, 1 };
            Console.WriteLine(FindMin(arr));

            Console.WriteLine(FindMax(arr));
            Console.WriteLine(NthMin(3, arr));
            Console.WriteLine(NthMax(3, arr));
        }

        static int FindMin(int[] numbers)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                { 
                    minValue = numbers[i];

                }
            }
            return minValue;
        }

        static int FindMax(int[] numbers)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                { 
                    maxValue = numbers[i];
                }
            }
            return maxValue;
        }

        static int NthMin(int n, int[] numbers)
        {
            List<int> minList = new List<int>();
            int nthMinimum = 0;

            for (int i = 0; i < n; i++)
            {
                minList.Add(FindMin(numbers));
                int numToRemove = FindMin(numbers);
                numbers = numbers.Where(val => val != numToRemove).ToArray();
            }

            for (int i = 0; i < minList.Count; i++)
            {
                nthMinimum = FindMax(minList.ToArray());
            }

            return nthMinimum;
        }

        static int NthMax(int n, int[] numbers)
        {
            List<int> maxList = new List<int>();
            int nthMaximum = 0;

            for (int i = 0; i < n; i++)
            {
                maxList.Add(FindMax(numbers));
                int numToRemove = FindMax(numbers);
                numbers = numbers.Where(val => val != numToRemove).ToArray();
            }

            for (int i = 0; i < maxList.Count; i++)
            {
                nthMaximum = FindMin(maxList.ToArray());
            }

            return nthMaximum;
        }





    }
}

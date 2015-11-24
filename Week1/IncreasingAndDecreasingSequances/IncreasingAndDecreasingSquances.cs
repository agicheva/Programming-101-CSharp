using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAndDecreasingSequances
{
    class IncreasingAndDecreasingSquances
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 9 };
            Console.WriteLine(IsDecreasing(arr));
            Console.WriteLine(IsIncreasing(arr));
        }

        static bool IsIncreasing(int[] sequance)
        {
            for (int i = 0; i < sequance.Length -1 ; i++)
            {
                if (sequance[i] >= sequance[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsDecreasing(int[] sequance)
        {
            for (int i = 0; i < sequance.Length - 1; i++)
            {
                if (sequance[i] <= sequance[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

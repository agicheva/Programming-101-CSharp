using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasSeries
{
    class LucasSeries
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] firstNElements = new int[num];
            for (int i = 0; i < firstNElements.Length; i++)
            {
                firstNElements[i] = LSeries(i);
            }

            for (int i = 0; i < firstNElements.Length; i++)
            {
                Console.Write(firstNElements[i] + " ");
            }

            Console.WriteLine();
        }

        static int LSeries(int input)
        {
            if (input == 0)
            {
                return 2;
            }
            else if (input == 1)
            {
                return 1;
            }

            int temp;
            temp = LSeries(input - 2) + LSeries(input - 1);

            return temp;
        }
    }
}

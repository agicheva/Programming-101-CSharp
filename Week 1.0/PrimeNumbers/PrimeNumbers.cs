using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));
            GetFirstNNumbers(input);
        }

        static bool IsPrime(int input)
        {
            bool isPrime = true;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
                
            }

            return isPrime;
        }

        static void GetFirstNNumbers(int n)
        {
            int counter = 0;
            List<int> primeList = new List<int>();
            int p = 0;
           
            for (int i = p; i < int.MaxValue; i++)
            {
                    
                if (IsPrime(i))
                {
                     counter++;
                     primeList.Add(i);
                }

                if (counter == n)
                {
                    p = i + 1;
                    break;

                }
            }
            

            for (int i = 0; i < primeList.Count; i++)
            {
                Console.Write(primeList[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

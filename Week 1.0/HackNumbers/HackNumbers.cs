using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
    class HackNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isHack(5));
            Console.WriteLine(FindNextHack(5));
        }

        static bool isHack(int input)
        {
            string str = input.ToString();
            int result = input;
            bool isHackNum = false;
            List<int> digits = new List<int>();

           while(result > 0)
            { 
                digits.Add(result % 2);
                result /= 2;
            }

            List<int> reversedDigits = digits.Reverse<int>().ToList();
            for (int i = 0; i < digits.Count && i < reversedDigits.Count; i++)
            {
                if (digits[i] != reversedDigits[i])
                {
                    isHackNum = false;
                }

                else
                {
                    isHackNum = true;
                }
            }
            return isHackNum;
        }
        
        static int FindNextHack(int input)
        {
            int nextHack = input + 1;
            
            while (true)
            {
                if (isHack(nextHack))
                {
                    return nextHack;
                }
                nextHack++;
            }
            return -1;
        }
    }
}

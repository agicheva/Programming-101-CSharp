using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    class BirthdayRanges
    {
        static void Main(string[] args)
        {
            List<int> birthday = new List<int>()
                { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            List<KeyValuePair<int, int>> range = new List<KeyValuePair<int, int>>() {
                new KeyValuePair<int, int>(4,9),
                new KeyValuePair<int, int>(6,7),
                new KeyValuePair<int, int>(200, 225),
                new KeyValuePair<int, int>(300,365)
            };

            foreach (var number in BirthdayRange(birthday, range))
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        static List<int> BirthdayRange(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < ranges.Count; i++)
            {
                int counter = 0;

                for (int j = 0; j < birthdays.Count; j++)
                {
                    if ((birthdays[j] >= ranges[i].Key) && (birthdays[j] <= ranges[i].Value))
                    {
                        counter++;
                    }
                }

                result.Add(counter);
            }

            return result;
        }
    }
}

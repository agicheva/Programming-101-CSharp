using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayThe13th
{
    class FridayThe13th
    {
        static void Main(string[] args)
        {
            Console.WriteLine(   UnfortunateFridays(2015, 2016));
        }

        static int UnfortunateFridays(int startYear, int endYear)
        {
            int counter = 0;
            DateTime date = new DateTime(startYear, 1, 13);

            while (date.Year <= endYear)
            {
                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    counter++;
                }
                date = date.AddMonths(1);
            }

            return counter;
        }
    }
}

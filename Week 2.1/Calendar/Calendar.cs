using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Threading;

namespace Calendar
{
    class Calendar
    {
        static void Main(string[] args)
        {
            PrintCalendar(11, 2015);

        }

        static void PrintCalendar(int month, int year)
        {
            DateTime date = new DateTime(year, month, 1);
            DateTime next = date.AddMonths(1);
            int nextLine = 7;

            //Console.OutputEncoding = Encoding.Default;
            //var culture = CultureInfo.CreateSpecificCulture("bg-BG");
            Console.WriteLine(date.ToString("MMMM"));

            for (int i = 0; i <= 6; i++)
            {
                Console.Write(date.ToString("dddd").PadRight(15));
                date = date.AddDays(1);
            }
            Console.WriteLine();

            date = new DateTime(year, month, 1);
            for (DateTime i = date; i < next; i=i.AddDays(1))
            {
                Console.Write(date.ToString("dd").PadRight(15));
                
                if (nextLine == date.Day)
                {
                    Console.WriteLine();
                    nextLine += 7;
                }

                date = date.AddDays(1);
            }
        }
    }
}

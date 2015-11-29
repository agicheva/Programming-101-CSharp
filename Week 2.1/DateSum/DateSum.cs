using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateSum
{
    class DateSum
    {
        static void Main(string[] args)
        {
            PrintDatesWithGivenSum(2015, 13);
        }

        static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime date = new DateTime(year, 1, 1);
            int sumDigitYear = (year / 1000) + ((year / 100) % 10) + ((year / 10) % 10) + (year % 10);


            
            while (date.Year == year)
            {
                int dayFirstDigit = date.Day / 10;
                int daySecondDigit = date.Day % 10;
                int monthFirstDigit = date.Month / 10;
                int monthSecondDigit = date.Month % 10;
                int dateSum;

                dateSum = dayFirstDigit + daySecondDigit + monthFirstDigit + monthSecondDigit + sumDigitYear;
                if (sum == dateSum)
                {
                    Console.WriteLine("{0: dd/mm/yyyy}", date);
                }
                date = date.AddDays(1);
            }
        }
    }
}

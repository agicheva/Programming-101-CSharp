using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialDate
{
    class SpecialDate
    {
        static void Main(string[] args)
        {
            HackerTime();
        }

        static void HackerTime()
        {
            DateTime currentDate = DateTime.Now;
            DateTime specialDate = new DateTime(currentDate.Year, 12, 21, 13, 37, 00);

            if (specialDate > currentDate)
            {
                currentDate.AddYears(1);
            }

            TimeSpan result = specialDate - currentDate;
            Console.WriteLine("{0:dd\\:hh\\:mm}", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
namespace ClockAngel
{
    class ClockAngel
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            DateTime time = new DateTime(2015, 11, 29, 16, 10, 0);
            DateTime time1 = new DateTime(2015, 11, 29, 16, 30, 0);

            Console.WriteLine(GetClockHandsAngle(time, true));
            Console.WriteLine(GetClockHandsAngle(time1, false));
        }

        static int GetClockHandsAngle(DateTime time, bool isExact)
        {
            int hourDegree;
            int minutesDegree;
            int angle;

            if (isExact)
            {
                if (time.Hour >= 12)
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour - 12, time.Minute, time.Second);

                    hourDegree = time.Hour * 30;
                    minutesDegree = time.Minute * 6;
                    angle = Math.Abs(hourDegree - minutesDegree);
                }
                else
                {
                    hourDegree = time.Hour * 30;
                    minutesDegree = time.Minute * 6;
                    angle = Math.Abs(hourDegree - minutesDegree);
                }
               

                return angle;
            }

            else
            {
                if (time.Hour >= 12)
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour - 12, time.Minute, time.Second);

                    hourDegree = (time.Hour * 60 + time.Minute) * (1 / 2);
                    minutesDegree = time.Minute * 6;
                    angle = Math.Abs(hourDegree - minutesDegree);
                }
                else
                {
                    hourDegree = (time.Hour * 60 + time.Minute) * (1 / 2);
                    minutesDegree = time.Minute * 6;
                    angle = Math.Abs(hourDegree - minutesDegree);
                }

                return angle;
            }
        }
    }
}

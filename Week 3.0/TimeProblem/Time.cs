using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProblem
{
    class Time
    {
        private DateTime myDate = new DateTime(2015, 12, 25, 15, 30, 00);
        
        public Time()
        {

        }
        public Time(DateTime Time)
        {
            myDate = Time;
        }

        public override string ToString()
        {
            string date = myDate.ToString("HH:mm:ss dd.MM.yyyy");
            return date;
        }

        public static Time Now()
        {
            Time time = new Time(DateTime.Now);
            
            return time;
        }
    }
}

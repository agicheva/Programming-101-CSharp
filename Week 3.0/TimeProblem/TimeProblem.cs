using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProblem
{
    class TimeProblem
    {
        static void Main(string[] args)
        {
            Time date = new Time();
            
            Console.WriteLine(date.ToString());
            Console.WriteLine(Time.Now());
        }
    }
}

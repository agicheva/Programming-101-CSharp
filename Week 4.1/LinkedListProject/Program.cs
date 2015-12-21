using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList.LinkedList<string>();
            list.Add("x");
            list.Add("g");
            list.Add("s");

            Console.WriteLine(list.Count);

            list.InsertAfter("g", "a");
            
            //list.InsertAt(10, "z"); 
            list.InsertAt(2, "z");
            list.Remove("z");
            list[1] = "m";

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}

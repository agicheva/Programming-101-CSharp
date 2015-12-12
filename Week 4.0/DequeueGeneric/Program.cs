using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeueGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Dequeue<string> queue = new Dequeue<string>();
            queue.AddToEnd("one");
            queue.AddToEnd("two");
            queue.AddToEnd("three");
            queue.AddToFront("zero");

            Console.WriteLine(queue.PeekFromFront());
            Console.WriteLine(queue.PeekFromEnd());
            if (queue.Contains("one"))
            {
                Console.WriteLine(true);
            }
        }
    }
}

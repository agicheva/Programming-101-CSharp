using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinamicArray;
using Map;

namespace MapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Map<int, string> myMap = new Map<int, string>();
            myMap.Add(1, "one");
            myMap.Add(2, "two");
            myMap.Add(3, "three");
            myMap.Add(4, "four");

            Console.WriteLine(myMap[2]);
            Console.WriteLine(myMap.ContainsKey(5));
            Console.WriteLine(myMap.ContainsValue("three"));

            myMap.Remove(1);
            for (int i = 0; i < myMap.Count; i++)
            {
                Console.WriteLine(myMap[myMap.Keys[i]]);
            }
        }
    }
}

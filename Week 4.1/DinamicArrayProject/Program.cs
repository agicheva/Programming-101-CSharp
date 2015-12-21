using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinamicArray;

namespace DinamicArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DinamicArray<int> arr = new DinamicArray<int>();

            Console.WriteLine(arr.Capacity);
            Console.WriteLine(arr.Count);

            arr.Add(5);
            arr.Add(10);
            arr.Add(7);
            arr.Add(8);
            arr.Add(11);
            arr.Add(12);
            arr.Add(17);

            Console.WriteLine(arr.Count);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr.Contains(15));
            Console.WriteLine(arr.IndexOf(11));
            arr.InsertAt(3, 15);
            arr.Remove(7);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

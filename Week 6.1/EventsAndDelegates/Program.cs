using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool FilterDelegate<T>(T item);
    public delegate T AggregateDelegate<T>(T aggregation, T nextItem);

    public class Program
    {
        public static bool EvenFilter(int item)
        {
            if (item % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool OddFilter(int item)
        {
            if (item % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static int SumAggregation(int aggregation, int newItem)
        {
            int result = aggregation + newItem;
            return result;
        }

        public static int SubAggregation(int aggregation, int newItem)
        {
            int result = aggregation - newItem;
            return result;
        }

        public static int AverageAggregation(int aggregation, int newItem)
        {
            int result = (aggregation + newItem) / 2;
            return result;
        }

        public static List<int> FilterCollection(List<int> collection, FilterDelegate<int> filter)
        {
            List<int> filteredCollection = new List<int>();

            foreach (var item in collection)
            {
                if (filter(item))
                {
                    filteredCollection.Add(item);
                }
            }

            return filteredCollection;
        }

        public static int AggregateCollection(List<int> collection, AggregateDelegate<int> aggregate)
        {
            int firstAggregation = aggregate(collection[0], collection[1]);

            if (collection.Count == 0)
            {
                return 0;
            }

            else if (collection.Count == 1)
            {
                return collection[0];
            }

            for (int i = 2; i < collection.Count; i++)
            {
                firstAggregation = aggregate(firstAggregation, collection[i]);
            }

            return firstAggregation;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 4, 7, 8, 2, 56, 5, 87, 90 };
            List<int> filteredList = new List<int>();

            //FilterDelegate<int> myFilter = EvenFilter;
            FilterDelegate<int> myFilter = OddFilter;
            AggregateDelegate<int> myAggregate = SumAggregation;

            filteredList = FilterCollection(list, myFilter);
            Console.WriteLine(AggregateCollection(list, myAggregate));


            foreach (var item in filteredList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------------------");

            AverageAggregator averageAgg = new AverageAggregator
               (delegate (object sender, decimal oldAverage, decimal newAverage)
               {
                   Console.Write("--->Handler: ");
                   Console.WriteLine("Average changed from {0} to {1}.", oldAverage, newAverage);
               });

            Console.WriteLine("---AverageAggregator---");
            Console.WriteLine();

            Console.WriteLine("Adding number to aggregator: 2");
            averageAgg.AddNumber(2);
            Console.WriteLine("Adding number to aggregator: 2");
            averageAgg.AddNumber(2);
            Console.WriteLine("Adding number to aggregator: 8");
            averageAgg.AddNumber(8);
            Console.WriteLine("Adding number to aggregator: 4");
            averageAgg.AddNumber(4);
            Console.WriteLine("Adding number to aggregator: 4");
            averageAgg.AddNumber(4);
            Console.WriteLine("Adding number to aggregator: 4");
            averageAgg.AddNumber(4);
            Console.WriteLine("Adding number to aggregator: -24");
            averageAgg.AddNumber(-24);
            Console.WriteLine("Adding number to aggregator: 0");
            averageAgg.AddNumber(0);
            Console.WriteLine("Adding number to aggregator: 0");
            averageAgg.AddNumber(0);
            Console.WriteLine("Adding number to aggregator: 10");
            averageAgg.AddNumber(10);
            Console.WriteLine("Adding number to aggregator: 1");
            averageAgg.AddNumber(1);
            Console.WriteLine("Adding number to aggregator: 1");
            averageAgg.AddNumber(1);
            Console.WriteLine("Adding number to aggregator: 2");
            averageAgg.AddNumber(2);

            Console.WriteLine();
        }
    }
}


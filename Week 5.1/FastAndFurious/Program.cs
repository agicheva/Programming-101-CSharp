using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW myBMW = new BMW();
            myBMW.MoveMiles(50);
            Console.WriteLine(myBMW.Mileage);
            Console.WriteLine(myBMW.isEcoFriendly(false));

            Console.WriteLine();

            Volkswagen golf = new Volkswagen();
            golf.MoveMiles(15);
            Console.WriteLine(golf.Mileage);
            Console.WriteLine(golf.isEcoFriendly(false));


        }
    }
}

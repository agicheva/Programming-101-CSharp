using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy smallCar = new Toy("car", "blue", "small");
            Toy bigCar = new Toy("car", "red", "big");
            Toy smallDoll = new Toy("doll", "blond", "small");

            Child tom = new Child("Tom", "boy", smallCar, bigCar);
            Child ani = new Child("Ani", "girl", smallDoll, bigCar);

            Adult john = new Adult("John", "male", tom, ani);

            Console.WriteLine(john.ToString());
        }
    }
}

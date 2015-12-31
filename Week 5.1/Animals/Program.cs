using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Crocodile crocodile = new Crocodile();
            Shark shark = new Shark();
            Owl owl = new Owl();

            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(crocodile);
            animals.Add(shark);
            animals.Add(owl);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Eat());
            }
            Console.WriteLine(dog.Greet());
        }
    }
}

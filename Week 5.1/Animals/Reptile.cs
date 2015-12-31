using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Reptile : Animal
    {
        public int temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

        public Reptile()
        {
            Name = "reptile";
        }
        public override string Eat()
        {
            string eating = string.Format("This {0} is eating.", Name);
            return eating;
        }

        public override string GiveBirth()
        {
            string givingBirth = string.Format("This {0} is giving birth.", Name);
            return givingBirth;
        }

        public override string Move()
        {
            string moving = string.Format("This {0} is moving.", Name);
            return moving;
        }

        public int Temperature()
        {
            Random rnd = new Random();
            temperature = rnd.Next(10, 100);
            return temperature;
        }
    }
}

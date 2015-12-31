using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal : Animal
    {
        public int Temperature
        {
            get
            {
                return Temperature;
            }
            set
            {
                Temperature = 37;
            }
        }

        public Mammal()
        {
            Name = "mammal";
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

        public virtual string Greet()
        {
            string greeting = string.Format("This {0} is greeting.", Name);
            return greeting;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Child : Person
    {
        public List<Toy> toys;

        public Child(string name, string gender, params Toy[] toys)
        {
            Name = name;
            Gender = gender;
            this.toys = new List<Toy>();

            foreach (var toy in toys)
            {
                this.toys.Add(toy);
            }
        }

        public override string DoDailyStuff()
        {
            string doDailyStuff = string.Format("{0} is playing", Name);
            return doDailyStuff;
        }
        
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(string.Format("Name: {0}", Name));
            str.AppendLine(string.Format("Gender: {0}", Gender));
            str.AppendLine(string.Format("Do daily stuff: {0}", DoDailyStuff()));

            foreach (var toy in toys)
            {
                str.AppendLine(string.Format("{0} is playing with {1}", Name, toy));
            }
            return str.ToString();
        }
    }
}

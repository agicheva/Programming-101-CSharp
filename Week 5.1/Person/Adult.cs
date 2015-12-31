using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Adult : Person
    {
        public List<Child> children = new List<Child>();
        
        public Adult(string name, string gender, params Child[] children)
        {
            Name = name;
            Gender = gender;
            this.children = new List<Child>();

            foreach (var child in children)
            {
                this.children.Add(child);
            }
        }

        public override string DoDailyStuff()
        {
            return "Work!";
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(string.Format("Name: {0}", Name));
            str.AppendLine(string.Format("Gender: {0}", Gender));

            foreach (var child in children)
            {
                str.AppendLine(string.Format("{0}'s child is: {1}", Name, child));
            }

            return str.ToString();
        }
    }
}

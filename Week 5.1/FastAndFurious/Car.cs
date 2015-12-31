using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    abstract class Car
    {
        protected int mileage;
        public abstract bool isEcoFriendly(bool testing);
        public void MoveMiles(int miles)
        {
            mileage += miles;
        }
    }
}

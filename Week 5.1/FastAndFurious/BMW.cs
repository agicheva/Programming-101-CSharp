using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    class BMW : Car
    {
        public BMW()
        {
            mileage = 0;
        }

        public override bool isEcoFriendly(bool testing)
        {
            return true;
        }

        public int Mileage
        {
            get
            {
                return mileage;
            }
        }
    }
}

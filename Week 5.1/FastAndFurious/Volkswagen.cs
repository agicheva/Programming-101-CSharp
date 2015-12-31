using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    class Volkswagen : Car
    {
        public Volkswagen()
        {
            mileage = 0;
        }

        public override bool isEcoFriendly(bool testing)
        {
            if (testing == true)
            {
                return true;
            }
            return false;
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

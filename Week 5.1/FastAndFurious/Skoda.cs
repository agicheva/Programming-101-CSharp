﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    class Skoda : Car
    {
        public Skoda()
        {
            mileage = 0;
        }

        public override bool isEcoFriendly(bool testing)
        {
            return true;
        }
    }
}

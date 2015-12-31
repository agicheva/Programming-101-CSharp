﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Mammal
    {
        public Cat()
        {
            Name = "cat";
        }

        public override string Greet()
        {
            return "Meow!";
        }
    }
}

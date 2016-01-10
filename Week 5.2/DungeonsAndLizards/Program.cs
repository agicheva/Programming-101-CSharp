using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new Hero("Bron", "Dragonslayer", 100, 100, 2);
            var w = new Weapon("The Axe of Destiny", 20);
            h.Equip(w);
            var s = new Spell("Fireball", 30, 50, 2);
            h.Learn(s);
            var map = new Dungeon(@"C:\Users\IVAN\Desktop\Programming-101-CSharp\Week 5.2\DungeonsAndLizards\bin\Debug\level1.txt");
            map.Spawn(h);
            map.PrintMap();

            map.MoveHero(Direction.Right);
            map.MoveHero(Direction.Down);
            map.PrintMap();

           
        }
    }
}

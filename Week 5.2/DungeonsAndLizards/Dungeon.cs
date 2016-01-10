using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonsAndLizards
{
    class Dungeon
    {
        private string path = @"C:\Users\IVAN\Desktop\Programming-101-CSharp\Week 5.2\DungeonsAndLizards\bin\Debug\level1.txt";
        private string treasurePath = @"C:\Users\IVAN\Desktop\Programming-101-CSharp\Week 5.2\DungeonsAndLizards\bin\Debug\treasures.txt";
        private int counter;
        private int lineCounter;
        private Hero hero;
        private Enemy enemy;
        public int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }

        internal Hero Hero
        {
            get
            {
                return hero;
            }

            set
            {
                hero = value;
            }
        }

        internal Enemy Enemy
        {
            get
            {
                return enemy;
            }

            set
            {
                enemy = value;
            }
        }

        public Dungeon(string path)
        {
            
        }

        public int LineCounter
        {
            get
            {
                return lineCounter;
            }

            set
            {
                lineCounter = value;
            }
        }

        public void PrintMap()
        {
            string map = File.ReadAllText(path);

            foreach (var item in map)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public bool Spawn(Hero hero)
        {
            string[] map = File.ReadAllLines(path);
            string line;

            for (int i = 0; i < map.Length; i++)
            {
                line = map[i];

                foreach (var symbol in line)
                {
                    if (symbol.Equals('S'))
                    {
                        line = line.Replace('S', 'H');
                        map[i] = line;
                        File.WriteAllLines(path, map);
                        return true;
                    }
                }
            }
            return false;
        }
        //TODO
        public bool MoveHero(Direction direction)
        {
            string map = File.ReadAllText(path);
            string[] lines = map.Split('\n');
            char[] line = lines[counter].ToCharArray();

            if (direction == Direction.Right)
            {
                for (int i = LineCounter; i <= LineCounter; i++)
                {
                    if (line[i + 1] == '#')
                    {
                        return false;
                    }

                    else if (line[i + 1] == '.')
                    {
                        line[i + 1] = 'H';
                    }

                    else if (line[i + 1] == 'T')
                    {
                        TakeTreasure();
                        line[i + 1] = 'H';
                    }

                    else if (line[i + 1] == 'E')
                    {
                        Fight fight = new Fight(this.hero, this.enemy);

                        if (fight.CheckGreaterDamage())
                        {
                            line[i] = 'H';
                        }

                        else
                        {
                            return false;
                        }
                    }

                    else if (line[i + 1] == 'G')
                    {
                        Console.WriteLine("You won.");
                        return true;
                    }
                    
                    else
                    {
                        return false;
                    }

                    string temp = new string(line);
                    lines[counter] = temp;
                    File.WriteAllLines(path, lines);
                }
                
                LineCounter++;
            }

            if (Direction.Up == direction)
            {
                if (counter == 0)
                {
                    return false;
                }

                line = lines[counter - 1].ToCharArray();
                for (int i = LineCounter; i <= LineCounter; i++)
                {
                    if (line[i] == '#')
                    {
                        return false;
                    }

                    else if (line[i] == '.')
                    {
                        line[i] = 'H';
                    }

                    else if (line[i] == 'T')
                    {
                        TakeTreasure();
                        line[i] = 'H';
                    }

                    else if (line[i] == 'E')
                    {
                        Fight fight = new Fight(this.hero, this.enemy);

                        if (fight.CheckGreaterDamage())
                        {
                            line[i] = 'H';
                        }

                        else
                        {
                            return false;
                        }
                    }

                    else if (line[i] == 'G')
                    {
                        Console.WriteLine("You won.");
                        return true;
                    }
         
                    else
                    {
                        return false;
                    }

                    string temp = new string(line);
                    lines[counter - 1] = temp;
                    File.WriteAllLines(path, lines);
                }
              
                counter--;
            }

            if (direction == Direction.Down)
            {
                line = lines[counter + 1].ToCharArray();
                for (int i = LineCounter; i <= LineCounter; i++)
                {
                    if (line[i] == '#')
                    {
                        return false;
                    }

                    else if (line[i] == '.')
                    {
                        line[i] = 'H';
                    }

                    else if (line[i] == 'T')
                    {
                        TakeTreasure();
                        line[i] = 'H';
                    }

                    else if (line[i] == 'E')
                    {
                        Fight fight = new Fight(this.hero, this.enemy);
                        if (fight.CheckGreaterDamage())
                        {
                            line[i] = 'H';
                        }

                        else
                        {
                            return false;
                        }
                    }
                    
                    else if (line[i] == 'G')
                    {
                        Console.WriteLine("You won.");
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                    string temp = new string(line);
                    lines[counter + 1] = temp;
                    File.WriteAllLines(path, lines);
                }

                counter++;
            }
            if (direction == Direction.Left)
            {
                line = lines[counter].ToCharArray();
                for (int i = LineCounter - 1; i <= LineCounter - 1; i++)
                {
                    if (line[i] == '#')
                    {
                        return false;
                    }

                    else if (line[i] == '.')
                    {
                        line[i] = 'H';
                    }
                   
                    else if (line[i] == 'T')
                    {
                        TakeTreasure();
                        line[i] = 'H';
                    }

                    else if (line[i] == 'G')
                    {
                        Console.WriteLine("You won.");
                        return true;
                    }

                    else if (line[i] == 'E')
                    {
                        Fight fight = new Fight(this.hero, this.enemy);
                        if (fight.CheckGreaterDamage())
                        {
                            line[i] = 'H';
                        }

                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    string temp = new string(line);
                    lines[counter] = temp;
                    File.WriteAllLines(path, lines);
                }
           
                LineCounter--;
            }
            return true;
        }
        public bool TakeTreasure()
        {
            string[] tresures = File.ReadAllLines(treasurePath);
            Random rnd = new Random();
            if (tresures[rnd.Next(0, tresures.Length)] == "health")
            {
                hero.TakeHealing(10);
                return true;
            }

            else if (tresures[rnd.Next(0, tresures.Length)] == "mana")
            {
                hero.TakeMana(10);
                return true;
            }

            else if (tresures[rnd.Next(0, tresures.Length)] == "spell")
            {
                Spell spell = new Spell("FireBall", 30, 50, 2);
                hero.Learn(spell);
                return true;
            }

            else if (tresures[rnd.Next(0, tresures.Length)] == "weapon")
            {
                Weapon weapon = new Weapon("Axe", 10);
                hero.Equip(weapon);
                return true;
            }
            return false;
        }
    }
}


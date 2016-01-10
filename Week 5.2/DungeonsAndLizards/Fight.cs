using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards
{
    class Fight
    {
        private Hero hero;
        private Enemy enemy;
        
        public Hero Hero
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

        public Enemy Enemy
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

        public Fight(Hero hero, Enemy enemy)
        {
            this.hero = hero;
            this.enemy = enemy;

            while (this.hero.IsAlive() || this.enemy.IsAlive())
            {
                if (hero.Weapon != null)
                {
                    HeroAttack("weapon");
                }
                HeroAttack("spell");

                if (enemy.Weapon != null)
                {
                    EnemyAttack("weapon");
                }
                else if(enemy.Spell != null)
                {
                    EnemyAttack("spell");
                }
                EnemyAttack(null);
            }
            if (hero.IsAlive())
            {
                Console.WriteLine("Hero won!");
            }
            else
            {
                Console.WriteLine("Enemy won!");
            }
        }

        //Return true if hero damage is greater than enemies
        public bool CheckGreaterDamage()
        {
            if (hero.Weapon.Damage > enemy.Damage + enemy.Weapon.Damage)
            {
                return true;
            }

            else if (hero.Spell.Damage > enemy.Damage + enemy.Spell.Damage)
            {
                return true;
            }
            return false;
        }

        public void HeroAttack(string usedWeapon)
        {
            if (usedWeapon == "weapon")
            {
                enemy.Health -= hero.Weapon.Damage;
            }

            else if(usedWeapon =="spell")
            {
                enemy.Health -= hero.Spell.Damage;
            }
        }

        public void EnemyAttack(string usedWeapon)
        {
            if (usedWeapon == "weapon")
            {
                hero.Health -= enemy.Weapon.Damage + enemy.Damage;
            }

            else if (usedWeapon == "spell")
            {
                hero.Health -= enemy.Spell.Damage + enemy.Damage;
            }

            else if (usedWeapon == null)
            {
                hero.Health -= enemy.Damage;
            }
        }

    }
}

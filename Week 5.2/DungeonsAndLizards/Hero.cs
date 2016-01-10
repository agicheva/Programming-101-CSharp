using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards
{
    class Hero
    {
        private string name;
        private string heroClass;
        private float health;
        private float mana;
        private float manaRegenerationRate;
        private Weapon weapon;
        private Spell spell;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string HeroClass
        {
            get
            {
                return heroClass;
            }

            set
            {
                heroClass = value;
            }
        }

        public float Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public float Mana
        {
            get
            {
                return mana;
            }

            set
            {
                mana = value;
            }
        }

        public float ManaRegenerationRate
        {
            get
            {
                return manaRegenerationRate;
            }

            set
            {
                manaRegenerationRate = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return weapon;
            }

            set
            {
                weapon = value;
            }
        }

        internal Spell Spell
        {
            get
            {
                return spell;
            }

            set
            {
                spell = value;
            }
        }

        public Hero(string name, string heroClass, float health, float mana, float manaRegenerationRate)
        {
            this.name = name;
            this.heroClass = heroClass;
            this.health = health;
            this.mana = mana;
            this.manaRegenerationRate = manaRegenerationRate;
        }

        public string KnowAs()
        {
            string knowAs = string.Format("{0} the {1}", this.name, this.heroClass);
            return knowAs;
        }

        public bool IsAlive()
        {
            if (this.health <= 0)
            {
                return false;
            }
            return true;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetMana()
        {
            return mana;
        }

        public bool CanCast()
        {
            if (mana <= 0 || mana < spell.ManaCost)
            {
                return false;
            }
            return true;
        }

        public void TakeDamage(int damagePoint)
        {
            if (!IsAlive())
            {
                return;
            }
            else
            {
                this.health -= damagePoint;
            }
        }

        public void TakeDamage(float damagePoint)
        {
            if (!IsAlive())
            {
                return;
            }
            else
            {
                this.health -= damagePoint;
            }
        }

        public bool TakeHealing(int healingPoint)
        {
            if (!IsAlive() || this.health == 100)
            {
                return false;
            }

            this.health += healingPoint;
            return true;
        }

        public void TakeMana(int manaPoint)
        {
            if (mana == 100 || !CanCast())
            {
                return;
            }

            mana += manaPoint;
        }
        //HOOW!?        TODO
        public void TakeMana()
        {
            this.mana += manaRegenerationRate;
        }

        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void Learn(Spell spell)
        {
            this.spell = spell;
        }

        public float Attack(Weapon weapon)
        {
            if (weapon == null)
            {
                return 0;
            }
            return weapon.Damage;
        }

        public float Attack(Spell spell)
        {
            if (spell == null)
            {
                return 0;
            }
            return spell.Damage;
        }
    }
}

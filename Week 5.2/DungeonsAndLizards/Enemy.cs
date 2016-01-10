using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards
{
    class Enemy
    {
        private float health;
        private float mana;
        private float damage;
        private Spell spell;
        private Weapon weapon;

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

        public float Damage
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
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

        internal Weapon Weapon
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

        public Enemy(float health, float mana, float damage)
        {
            this.health = health;
            this.mana = mana;
            this.damage = damage;
        }

        public bool IsAlive()
        {
            if (this.health <= 0)
            {
                return false;
            }
            return true;
        }

        public bool CanCast()
        {
            if (this.mana <= 0 || this.mana < spell.ManaCost)
            {
                return false;
            }
            return true;
        }

        public float GetHealth()
        {
            return this.health;
        }

        public float GetMana()
        {
            return this.mana;
        }

        public void TakeHealing(float healingPoints)
        {
            if (!IsAlive() || health == 100)
            {
                return;
            }
            health += healingPoints;
        }

        public void TakeMana(float manaPoints)
        {
            this.mana += manaPoints;
        }

        public float Attack(Weapon weapon)
        {
            if (weapon == null)
            {
                return this.damage;
            }

            return weapon.Damage + this.damage;
        }

        public float Attack(Spell spell)
        {
            if (spell == null)
            {
                return this.damage;
            }
            return spell.Damage + this.damage;
        }
    }
}


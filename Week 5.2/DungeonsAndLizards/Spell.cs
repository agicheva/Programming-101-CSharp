using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndLizards
{
    class Spell
    {
        private string type;
        private float damage;
        private float manaCost;
        private float castRange;

        public string Name
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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

        public float ManaCost
        {
            get
            {
                return manaCost;
            }

            set
            {
                manaCost = value;
            }
        }
        //TODO
        public float CastRange
        {
            get
            {
                return castRange;
            }

            set
            {
                castRange = value;
            }
        }

        public Spell(string type, float damage, float manaCost, float castRange)
        {
            this.type = type;
            this.damage = damage;
            this.manaCost = manaCost;
            this.castRange = castRange;
        }
    }
}

using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        private int healthPoints;
        private int level;
        private string name;

        private Faction faction;

        private Armor bodyArmor;
        private Weapon weapon;

        public virtual int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Health Points should be >=0 and <= 10.");
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value > 0 && value < 20)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the lvl should be >0 or <20.");
                }
            }

        }

        public Faction Faction
        {
            get
            {
                return faction;
            }
            set
            {
                this.faction = value;
            }
        }
    
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropriate length of your name, it has to be between 3 and 12 characters!");
                }
            }
        }

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }
}

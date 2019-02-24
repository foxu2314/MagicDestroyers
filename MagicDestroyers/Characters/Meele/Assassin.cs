using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters
{
    public class Assassin
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;

        private LightLeatherVest bodyArmor;
        private Sword weapon;


        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Ability Points should be >=0 and <=10");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    healthPoints = value;
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
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the lvl should be >0 or <20.");
                }
            }

        }

        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Meele" || faction == "Spellcasters")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropriate faction, please choose either Meele or Spellcaster!");
                }
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

        public LightLeatherVest BodyArmor
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

        public Sword Weapon
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


        public Assassin()
            : this("Assassin", 60)
        {
        }
        public Assassin(string name, int level)
            : this(name, level, 600)
        {
        }
        public Assassin(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = "Meele";
            this.AbilityPoints = 600;
            this.Weapon = new Sword();
            this.BodyArmor = new LightLeatherVest();
        }


        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}


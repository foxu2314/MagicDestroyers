using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blant;
using System;

namespace MagicDestroyers.Characters
{
    public class Druid
    {
        public const int DEFAULT_ABILITYPOINTS = 60;
        public const int DEFAULT_HEALTHPOINTS = 600;
        public const int DEFAULT_LEVEL = 65;
        private const string DEFAULT_NAME = "Adrian";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private LightLeatherVest bodyArmor;
        private Staff weapon;


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

        public Faction Faction
        {
            get
            {
                return this.faction;
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

        public Staff Weapon
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


        public Druid()
            : this("Druid", 50)
        {
        }
        public Druid(string name, int level)
            : this(name, level, 500)
        {
        }
        public Druid(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = 500;
            this.Weapon = new Staff();
            this.BodyArmor = new LightLeatherVest();
        }


        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starbust()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}


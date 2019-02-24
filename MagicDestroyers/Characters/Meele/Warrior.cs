﻿using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters
{
    public class Warrior
    {
        public const int DEFAULT_ABILITYPOINTS = 10;
        public const int DEFAULT_HEALTHPOINTS = 100;
        public const int DEFAULT_LEVEL = 10;
        private const string DEFAULT_NAME = "Warrior";

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string name;

        private Faction faction;

        private ChainLink bodyArmor;
        private Axe weapon;


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
                if (value >= 0 && value <= 100)
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

        public ChainLink BodyArmor
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

        public Axe Weapon
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


        public Warrior()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Warrior(string name, int level)
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, Faction.Default)
        {
        }
        public Warrior(string name, int level, int healthPoints, Faction faction)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = new Axe();
            this.BodyArmor = new ChainLink();
            this.Faction = faction;
        }
        

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }

}

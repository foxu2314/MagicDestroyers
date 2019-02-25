﻿using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters
{
    public class Assassin
    {
        public const int DEFAULT_ABILITYPOINTS = 30;
        public const int DEFAULT_HEALTHPOINTS = 300;
        public const int DEFAULT_LEVEL = 35;
        private const string DEFAULT_NAME = "Steve";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private Faction faction;
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
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
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


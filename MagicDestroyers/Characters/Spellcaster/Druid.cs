﻿using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blant;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        public const int DEFAULT_MANAPOINTS = 60;
        public const int DEFAULT_HEALTHPOINTS = 600;
        public const int DEFAULT_LEVEL = 65;
        private const string DEFAULT_NAME = "Adrian";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 160)
                {
                    this.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Health Points should be >=0 and <= 160.");
                }
            }
        }
        private LightLeatherVest bodyArmor;
        private Staff weapon;

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
           base.Name = name;
           base.Level = level;
           base.HealthPoints = healthPoints;
           base.Faction = DEFAULT_FACTION;
           base.ManaPoints = 500;
           base.Weapon = new Staff();
           base.BodyArmor = new LightLeatherVest();
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

        public override void Attack()
        {
            this.Moonfire();
        }

        public override void Defend()
        {
            this.OneWithTheNature();
        }

        public override void SpecialAttack()
        {
            this.Starbust();
        }
    }
}


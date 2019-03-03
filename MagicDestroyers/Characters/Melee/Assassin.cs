using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        public const int DEFAULT_ABILITYPOINTS = 30;
        public const int DEFAULT_HEALTHPOINTS = 300;
        public const int DEFAULT_LEVEL = 35;
        private const string DEFAULT_NAME = "Steve";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    this.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Health Points should be >=0 and <= 130.");
                }
            }
        }
        private LightLeatherVest bodyArmor;
        private Sword weapon;

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
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
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

        public override void Attack()
        {
            this.Raze();
        }

        public override void Defend()
        {
            this.Survival();
        }

        public override void SpecialAttack()
        {
            this.BleedToDeath();
        }
    }
}


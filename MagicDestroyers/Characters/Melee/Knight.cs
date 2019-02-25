using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blant;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        public const int DEFAULT_ABILITYPOINTS = 20;
        public const int DEFAULT_HEALTHPOINTS = 200;
        public const int DEFAULT_LEVEL = 25;
        private const string DEFAULT_NAME = "Joe";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private readonly ChainLink DEFAULT_BODY_ARMOR = new ChainLink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Health Points should be >=0 and <= 120.");
                }
            }
        }
        private ChainLink bodyArmor;
        private Hammer weapon;

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
        public Hammer Weapon
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

        public Knight()
            : this("Knight", 40)
        {
        }
        public Knight(string name, int level)
            : this(name, level, 400)
        {
        }
        public Knight(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void HolySoul()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }
        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}


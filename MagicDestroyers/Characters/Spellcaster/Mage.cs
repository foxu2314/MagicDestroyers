using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blant;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        public const int DEFAULT_MANAPOINTS = 50;
        public const int DEFAULT_HEALTHPOINTS = 500;
        public const int DEFAULT_LEVEL = 55;
        private const string DEFAULT_NAME = "Joana";
        private const Faction DEFAULT_FACTION = Faction.Meele;

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Health Points should be >=0 and <= 150.");
                }
            }
        }
        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
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

        public Mage()
            : this("Mage", 30)
        {
        }
        public Mage(string name, int level)
            : this(name, level, 300)
        {
        }
        public Mage(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.ManaPoints = DEFAULT_MANAPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        public void Firewall()
        {
            throw new NotImplementedException();
        }
        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}


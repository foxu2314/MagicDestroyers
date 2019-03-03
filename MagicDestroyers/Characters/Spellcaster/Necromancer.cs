using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        public const int DEFAULT_MANAPOINTS = 40;
        public const int DEFAULT_HEALTHPOINTS = 400;
        public const int DEFAULT_LEVEL = 45;
        private const string DEFAULT_NAME = "Donn";
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
                if (value >= 0 && value <= 140)
                {
                    this.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Health Points should be >=0 and <= 140.");
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

        public Necromancer()
            : this("Necromancer", 20)
        {
        }
        public Necromancer(string name, int level)
            : this(name, level, 200)
        {
        }
        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANAPOINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }
        public void VampireTouch()
        {
            throw new NotImplementedException();
        }
        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.ShadowRage();
        }

        public override void Defend()
        {
            this.BoneShield();
        }

        public override void SpecialAttack()
        {
            this.VampireTouch();
        }
    }
}


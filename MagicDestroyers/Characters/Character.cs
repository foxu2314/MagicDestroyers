using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        private int healthPoints;
        private int level;
        private string name;

        private Faction faction;

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
    }
}

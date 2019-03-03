using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon
    {
        private int damagePoints;
        public int DamagePoints
        {
            get
            {
                return this.damagePoints;
            }
            set
            {
                if (damagePoints >= 0)
                {
                this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The damage has to be higher or equal to 0");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors
{
    public class Armor
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (armorPoints >= 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The armor points has to be higher or equal to 0");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class ChainLink : Heavy
    {
        private const int DEFAULT_ARMOR_POINTS = 50;

        public ChainLink()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public ChainLink(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}

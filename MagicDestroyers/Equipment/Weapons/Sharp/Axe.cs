using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Axe(int damagePoints)
        {
            base.DamagePoints = damagePoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}

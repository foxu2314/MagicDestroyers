using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blant
{
    public class Staff : Blant
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Staff(int damagePoints)
        {
            base.DamagePoints = damagePoints;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}

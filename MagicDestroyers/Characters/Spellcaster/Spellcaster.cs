using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;

        public virtual int ManaPoints
        {
            get
            {
                return manaPoints;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Improper value, the Ability Points should be >=0 and <=10");
                }
            }
        }
    }
}

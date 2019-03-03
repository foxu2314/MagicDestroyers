using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior();
            Character knight = new Knight();
            Character assassin = new Assassin();
            Character necromancer = new Necromancer();
            Character mage = new Mage();
            Character druid = new Druid();

            List<Character> meeleTeam = new List<Character>();
            List<Character> spellTeam = new List<Character>();
            meeleTeam.Add(warrior);
            meeleTeam.Add(knight);
            meeleTeam.Add(assassin);
            spellTeam.Add(necromancer);
            spellTeam.Add(mage);
            spellTeam.Add(druid);
        }

    }
}

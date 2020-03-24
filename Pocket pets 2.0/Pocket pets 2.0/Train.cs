using System;
using static System.Console;
using static Pocket_pets_2._0.Dragon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Train
    {
        public Train()
        {

        if (Dragon.IHasDragon == true)
            {
                WriteLine("How DO you train your dragon?");
                return;
            }
            if (Smog.IHasSmog == true)
            {
                WriteLine("you play a little game for gold with your Smog dragon, but seem to be losing.");
                return;
            }
            if (Falkor.IHasFalkor == true)
            {
                WriteLine("You quiz your falkor dragon with trivia.");
                return;
            }
        }
    }
}

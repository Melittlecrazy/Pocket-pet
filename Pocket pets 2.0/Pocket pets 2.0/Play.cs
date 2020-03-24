using System;
using static System.Console;
using static Pocket_pets_2._0.Dragon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Play
    {
        public Play()
        {

        if (Dragon.IHasDragon == true)
            {
                WriteLine("You play fetch with a stick and dodge fire as you though the stick back and forth.");
                return;
            }
            if (Smog.IHasSmog == true)
            {
                WriteLine("You chase your Smog dragon as they run after gold.");
                return;
            }
            if (Falkor.IHasFalkor == true)
            {
                WriteLine("You Try to find books with falkor and wonder around a Book store.");
                return;
            }
        }
    }
}

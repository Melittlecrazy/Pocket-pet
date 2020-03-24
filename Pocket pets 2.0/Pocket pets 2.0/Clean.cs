using System;
using static System.Console;
using static Pocket_pets_2._0.Dragon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Clean
    {
        public Clean()
        {
            WriteLine("How do you want to clean your dragon?");

            if (Dragon.IHasDragon == true)
            {
                WriteLine("These are the ways you can wash your Dragon! \n1)Ring the bath bell. \n2)Bribe with food.");
                string input = ReadLine();
                if (input == "1")
                {
                    WriteLine("They hop in the bath and swim around.");
                    return;
                }
                else if (input == "2")
                {
                    WriteLine("You dangle the food above the bath as your dragon runs to grab it but falls in.");
                    return;
                }
            }
            if (Smog.IHasSmog == true)
            {
                WriteLine("These are the ways you can wash your Smog! \n1)Bribe with Gold. \n2)[option coming soon]");
                string input = ReadLine();
                if (input == "1")
                {
                    WriteLine("They agree after you give them gold.");
                    return;
                }
                else if (input == "2")
                {
                    WriteLine("I need more gold to make.");
                }
            }
            if (Falkor.IHasFalkor == true)
            {
                WriteLine("These are the ways you can wash your Falkor! \n1) Bribe with books. \n2) Through water on them.");
                string input = ReadLine();
                if (input == "1")
                {
                    WriteLine("They agree after you give them Books.");
                    return;
                }
                else if (input == "2")
                {
                    WriteLine("They get all soggy and upset they you wet their books but still cares for you.");
                    return;
                }
            }
        }
    }
}

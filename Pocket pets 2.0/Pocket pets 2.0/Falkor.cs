using System;
using static System.Console;
using static Pocket_pets_2._0.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Falkor : Dragon
    {
        public Falkor(string _name, string _discription) : base(_name, _discription)
        {
            Name = _name;
            Description = _discription;
        }
        public override void Act()
        {
            Print("What's my name?");
            Name = ReadLine();
            Print($" Oh yeah, It's {Name} the Falkor Dragon.");
            IHasFalkor = true;
            return;
        }
        public static bool IHasFalkor;
    }
}

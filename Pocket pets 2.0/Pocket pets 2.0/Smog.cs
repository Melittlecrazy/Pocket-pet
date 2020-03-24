using System;
using static System.Console;
using static Pocket_pets_2._0.Utility;
using static Pocket_pets_2._0.Items;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Smog : Dragon, IGreedy
    {

        public Smog(string _name, string _discription) : base(_name, _discription)
        {
            Name = _name;
            Description = _discription;
        }

        public override void Act()
        {
            Print("What's my name?");
            Name = ReadLine();
            Print($" Oh yeah, It's {Name} the Smog Dragon.");
            IHasSmog = true;
            
            return ;
        }
        public static bool IHasSmog;

         void IGreedy.Steal()
        {
            for (int i = 0; i<= 1; i++ )
            {
                int stole = random.Next(21);
                if (stole >= 10)
                {
                    //new GetGold();
                    GoldP gold = Given;
                }
            }
        }
    }
}

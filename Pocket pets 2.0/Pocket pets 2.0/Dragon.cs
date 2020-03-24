using System;
using static System.Console;
using static Pocket_pets_2._0.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Dragon : Species
    {
		private string name = "Tis a dragoon!";
		public new string Name { get => name; set => name = value; }
		public string Description = "";

		//public string Flame;

		public virtual void Act()
		{
			Print("What's my name?");
			Name = ReadLine();
			Print($" Oh yeah, It's {Name} the Dragon.");
			IHasDragon = true;
			return;
		}
		public static bool IHasDragon;
		//public virtual void Status()
		//{

		//}
		public void Status(string _message)
		{
			Print(_message);
			//WriteLine(this.Name + " spits fire at you, " + this.Flame);
		}
		public Dragon(string _name, string _discription)
		{
			name = _name;
			//Flame = "Whoosh!!!";
		}

		//public void GiveGold()
		//{//player is supposed to offer gold to dragons because dragons


		//		//Items.Gold.Add(new Item(""));

		//}

	}
}

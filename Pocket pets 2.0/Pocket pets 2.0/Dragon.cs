using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Dragon : Species
    {
		public string Flame;

		public Dragon(string newName)
		{
			Name = newName;
			Flame = "Whoosh!!!";
		}

		public override void Talk()
		{
			base.Talk();
			Console.WriteLine(this.Name + " spits fire at you, " + this.Flame);
		}
		
		public void GiveGold()
		{//player is supposed to offer gold to dragons because dragons
			
			foreach (string n in )
			{
				aryDropDown.Items.Add(n);
			}
		}

	}
}

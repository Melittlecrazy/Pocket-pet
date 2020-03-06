using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Species
    {
		public string Name;
		public string Birth;
		public string Skin;

		public Species(string newName)
		{
			Name = newName;
			Birth = " can duplicate it's self through magic and capitalism, like baby Mr.Peanut.";
			Skin = " has hair.";
		}

		public virtual void Talk()
		{
			Console.WriteLine($"{Name} says Hi.");
		}
 
	}
}

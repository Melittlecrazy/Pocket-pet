using System;
using static System.Console;
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
		public bool HasHair;
		public int Age;


		public Species(string newName)
		{
			Name = newName;
			Birth = " can duplicate it's self through magic and capitalism, like baby Mr.Peanut.";
			
		}

		public virtual void Status()
		{
			WriteLine($"{Name} says Hi.");
		}
 
	}
}

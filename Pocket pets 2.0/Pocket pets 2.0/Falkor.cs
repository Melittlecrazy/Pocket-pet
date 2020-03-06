using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Falkor : Dragon
    {
		public Falkor(string newName) : base(newName)
		{
			Flame = "Falkor doesn't actually spit out flames.";
		}

		public override void Talk()
		{
			base.Talk();
			Console.WriteLine("\nFalkor might not actually be a dragon...");
		}
	}
}

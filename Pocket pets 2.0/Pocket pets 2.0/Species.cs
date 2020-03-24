using System;
using static System.Console;
using static Pocket_pets_2._0.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Species
    {
		public string Name =  "";

		List<Dragon> dragons = new List<Dragon>();
		public Species()
		{
			SetUp();
			
			return;
			//Greetings();
			
		}
		private void Greetings()
		{
			Print("Sup.");
		}
		private void SetUp()
		{
			Title = "Adopt-a-dragon";
			BackgroundColor = ConsoleColor.Cyan;
			ForegroundColor = ConsoleColor.Red;
			Clear();
		}
	}
}

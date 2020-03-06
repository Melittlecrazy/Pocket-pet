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
		public string Name;
		public string Birth;
		public int Age;
		public int Day;

		List<Dragon> dragons = new List<Dragon>();
		public Species()
		{
			SetUp();

			Greetings();
			
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
		public void Menu()
		{
			if(HasDragons())
			{
				Print("which dragon do you want to adopt?");
				foreach (Dragon dragon in dragons)
				{
					Print($"      * {dragon.Name}");
				}
			}
			string input = ReadLine();
		}

		private bool HasDragons()
		{
			if (dragons.Count >= 1)
				return true;
			return false;
		}

		private void Adopt()
		{
			dragons.Add(new Dragon("Dragoon","I am a regular dragon."));
			dragons.Add(new Falkor("Falkor","Let's read books!"));
			dragons.Add(new Smog("Smog","Give me gold."));
		}
	}
}

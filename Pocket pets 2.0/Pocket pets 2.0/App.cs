using System;
using static System.Console;
using static Pocket_pets_2._0.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class App
    {
        public App()
        {
            new Species();
            WriteLine("Hi, Welcome to the Adopt-a-dragon.");
            Adopt();
            MainMenu();
        }

        public int Day = 1;
        public bool Dirty = false;
        public bool Hungry = false;
        public void MainMenu()
        {
            WriteLine($"It's Day: {Day}. Is Dirty: {Dirty}. Is Hungry:{Hungry}");
            if (Smog.IHasSmog == true) WriteLine(ConsoleColor.Yellow + "You have {Gold}Gold pieces.");
                WriteLine("1) Clean pet" +
                "\n2) Feed pet." +
                "\n3) Play" +
                "\n4) Train" +
                "\n5) Shop" +
                "\nPress 0 to nap till next day.");
        string choice = ReadLine();
            if (choice == "1")
            {
                new Clean();
                Dirty = false;
                Day = Day + 1;
                MainMenu();
            }
            else if (choice == "2")
            {
                WriteLine("You give your dragon food! They are no longer hungry!");
                Hungry = false;
                MainMenu();
            }
            else if (choice == "3")
            {
                new Play();
                Dirty = true;
                Hungry = true;
                Day = Day + 1;
                MainMenu();
            }
            else if (choice == "4")
            {
                new Train();
                Dirty = true;
                Day = Day + 1;
                MainMenu();
            }
            else if (choice == "5")
            {
                WriteLine("sorry we don't have a shop yet.");
                //new Shop();
            }
            else if (choice == "0")
            {
                WriteLine("You and your dragon rest the day away.");
                Day = Day + 1;
                MainMenu();
            }

            if (Day >= 10)
            {
                WriteLine("Your 10 day trial run is done, do you want to keep your dragon?");
            }
        }
         void Adopt()
        {
            WriteLine("You can choose between:\n1) Generic Dragon. \n2) Falkor. \n3) Smog.");
            string choose = ReadLine();
            if (choose == "1")
            {
                Dragon generic = new Dragon("","");
                generic.Act();
            }
            if (choose == "2")
            {
                Falkor falkor = new Falkor("","");
                falkor.Act();
            }
            if (choose == "3")
            {
                Smog smog = new Smog("","");
                smog.Act();
            }
            WriteLine("Press any key to continue.");
            ReadKey();
            MainMenu();
        }
        
        
    }
}

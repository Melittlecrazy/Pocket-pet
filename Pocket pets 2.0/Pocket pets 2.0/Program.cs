using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hi, Welcome to the Adopt-a-dragon.");
            Status();
            WriteLine("1)clean pet" +
                "\n2)feed pet." +
                "\n3) Play" +
                "\n4) Train" +
                "\n5) Shop");
            string choice = ReadLine();
            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {
                WriteLine("sorry we don't have a shop yet.");
            }
        }
    }
}

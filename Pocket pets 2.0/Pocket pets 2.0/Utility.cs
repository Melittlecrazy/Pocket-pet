using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Utility
    {
        public delegate void GoldP(string _message);
        public static GoldP Given = PrintConsole;
        public static Random random = new Random();
        public static void Print(string _message)
        {
            WriteLine(_message);
        }
        public static void PrintConsole(string _message) => WriteLine($"{_message}");
        public static void Greed(string _message) => Given($"OH SWEET! Your dragon got gold!.\n{_message}");
    }
}

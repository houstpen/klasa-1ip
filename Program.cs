using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwsza_konsola
{
    internal class Uczen
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Title = "Moja Konsola!";
            Console.WriteLine("Klasa 2P");
            Console.WriteLine("Grupa 1");
            Console.WriteLine("Mechaniak");
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Caps lock: " + Console.CapsLock); 
            Console.ReadKey();

        }
    }
}

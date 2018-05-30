using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz swoje imię...");
            string name = Console.ReadLine();
            Console.WriteLine("Czesc, " + name);

            Console.WriteLine("Wpisz swoj wiek...");
            int wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Masz " + wiek + " lat");

            Console.ReadLine();
            
        }
    }
}
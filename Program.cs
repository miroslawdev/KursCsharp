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
                      
            for (;  ; )
            {
                Przywitanie();
                Wiek();
                Ustawienia();

            }
        }

        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }

        private static void Wiek()
        {
            Console.Write("Wpisz swoj wiek: ");
            int wiek;
            bool result = int.TryParse(Console.ReadLine(), out wiek);

            if (wiek > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Super. Jak masz dowód to możesz kupić browce!");
            }
            else if (result == false)
            {
                Console.WriteLine("Uzywaj tylko cyfr!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Musisz jeszcze poczekac zanim kupisz alko!!!");
            }
        }

        private static void Przywitanie()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Czesc, " + name);
        }
    }
}
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
            // int.Try Parse instrukcja zwraca typ bool i tu wyrzuca false gdy w "Wpisz swoj wiek..." zostaną użyte
            //litery.
            int wiek;
            bool result = int.TryParse(Console.ReadLine(), out wiek);

            if (wiek > 18)
            {
                Console.WriteLine("Super. Jak masz dowód to możesz kupić browce!");
            }
            else if (result == false)
            {
                Console.WriteLine("Uzywaj tylko cyfr!");
            }
            else
            {
                Console.WriteLine("Musisz jeszcze poczekac zanim kupisz alko!!!");

            }
           

            Console.ReadLine();
            
        }
    }
}
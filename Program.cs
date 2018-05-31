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
            
            //for (int i = 0; i < 10; i++) - taka petla wykona sie 10 razy
            //for (;  ; ) - taka petla bedzie sie wykonywać w nieskończoność.
            for (;  ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
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
        }
    }
}
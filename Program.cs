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
            // Uruchomic z konsoli z parametrem np:Mirek z lokalizacji -
            //D:\CISCO\C#\projekty C#\KursCsharp\Aplikacja1\bin\Debug>Aplikacja1 Mirek
            //uruchomienie w VS wywali wyjatek.
            string name = args[0];
            Console.WriteLine("Witaj, " + name);
        }
    }
}
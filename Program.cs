using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projekt
{
    class Program
    {
       private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Witaj w rejestrze osób!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[1] Dodaj osobę");
            Console.WriteLine();
            Console.WriteLine("[2] Usuń osobę");
            Console.WriteLine();
            Console.WriteLine("[3] Wyświetl osobę");
            Console.WriteLine();
            Console.WriteLine("[0] Wyjście");
            Console.WriteLine();
        }

        private static int GetInt(string msg)
        {
            Console.Write(msg);
            int r = 0;
            if (!int.TryParse(Console.ReadLine(), out r))
            {
                throw new ArgumentException("Podaj CYFRĘ!");
            }
            return r;
        }

        private static void MainLoop()
        {
            bool exit = false;
            Osoba osoba = new Osoba();
            while (!exit)
            {
                int input;
                DisplayMenu();
                try
                {
                    input = GetInt("Wybierz: ");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Zły wybór!");
                    Console.ReadKey();
                    continue;
                }
              
                switch (input)
                {
                    case 1:
                        break;

                    case 2:
                        break;
                    case 3:
                        osoba.printInfo();
                        Console.ReadKey();
                        break;
                    case 0:
                        exit = true;
                        break;

                }

            }

        }

        static void Main(string[] args)
        {
            MainLoop();
        }

    }
}

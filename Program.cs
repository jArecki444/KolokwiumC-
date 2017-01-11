using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static public ConsoleKey key;
        static void Main(string[] args)
        {
            Podroz p1 = new Podroz();

            while (key != ConsoleKey.E)
            {
                Console.Clear();
                Console.WriteLine(@"Aplikacja do składania pociągow
Co chcesz zrobic?
A - dodaj Autobus
P - dodaj Pociąg
D - ustaw date podróży
S - sprawdz czy data jest poprawna
Z - Wypisz informacje
X - Usuń wszystkie informacje
O - Usuń ostatni wpis
E - Wyjście");
                key = Console.ReadKey().Key;


                switch (key)
                {
                    case ConsoleKey.A:
                        {
                            Console.WriteLine("Podaj ilosc miejsc");
                            int iloscMiejscA = int.Parse(Console.ReadLine());
                            p1.DodajAutobus(iloscMiejscA);
                            break;
                        }
                    case ConsoleKey.P:
                        {
                            Console.WriteLine("Podaj ilosc miejsc");
                            int iloscMiejscP = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n Podaj dlugosc trasy");
                            int dlugoscTrasy = int.Parse(Console.ReadLine());
                            p1.DodajPociag(iloscMiejscP, dlugoscTrasy);
                            break;
                        }
                    case ConsoleKey.Z:
                        {
                            Console.WriteLine(p1.ToString());
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.X:
                        {
                            p1.Wyczysc();
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.O:
                        {
                            p1.UsunOstatni();
                            Console.WriteLine("Usuwam ostatni wpis");
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.WriteLine("Ustaw date podrózy w systemie DD/MM/YYYY ");
                            string dataPodrozy=Console.ReadLine();
                            DateTime dt = Convert.ToDateTime(dataPodrozy);
                            p1.UstawDate(dt);
                            break;
                        }
                   /* case ConsoleKey.S:
                        {
                           
                            if(p1.SprawdzDate)
                            {
                                Console.WriteLine("Data ustawiona poprawnie ");
                            }
                            else
                            {
                                Console.WriteLine("Data ustawiona niepoprawnie ");
                            }
                            break;
                        }*/
                    
                }
            }
        }
    }
}

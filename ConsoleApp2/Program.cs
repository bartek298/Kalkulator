using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Kalkulator");
            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę:");
            double liczba2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz dzialanie \n" +
                "1.Dodawanie\n" +
                "2.Odejmowanie\n" +
                "3.Mnożenie\n" +
                "4.Dzielenie");
            int wybor = int.Parse(Console.ReadLine());
            double wynik = 0;

            switch(wybor)
            {
                case 1:
                    wynik = liczba1 + liczba2;
                    break;
                case 2:
                    wynik = liczba1 - liczba2;
                    break;
                case 3:
                    wynik = liczba1 * liczba2;
                    break;
                case 4:
                    wynik = liczba1 / liczba2;
                    break;
                default:
                    Console.WriteLine("Nie ma takiego czegoś");
                    break;
            }
            Console.WriteLine($"Twój wynik to:{wynik}");

            Console.ReadKey();


        }
    }
}

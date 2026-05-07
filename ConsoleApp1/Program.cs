using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Liczba wynosi: {x}" );

            var y = "345";


            Class1.Metoda1();
            Class1 nowyObiekt = new Class1(); //stworzenie obiektu
            nowyObiekt.Metoda2();
            int suma = nowyObiekt.Metoda3();
            Console.WriteLine($"suma liczb wynosi:{suma}");
            int iloczyn = nowyObiekt.Metoda4(3, 7);
            Console.WriteLine($"iloczyn wynosi:{iloczyn}");


            Console.ReadKey();
        }
    }
}

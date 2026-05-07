using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void Metoda1()
        {
            Console.WriteLine("Metoda 1 static");
        }

        public void Metoda2()
        {
            Console.WriteLine("Metoda 2 ");

        }
        public int Metoda3()
        {
            int a = 567;
            int b = 987;
            return a + b;

        }
        public int Metoda4(int a,int b)
        {
            return a * b;
            
        }
    }
}

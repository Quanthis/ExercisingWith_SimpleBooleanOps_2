using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 10;
            bool wynik;
            wynik = (x >= 2 | y++ >= 2);                    // |-alternatywa bezwarunkowa
            Console.WriteLine(wynik);                       // ||-alternatywa warunkowa; w koniunkcji (App5) podobnie
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}

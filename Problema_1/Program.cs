using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ecuatie();

        }


        private static void Ecuatie()
        {
            int a, b;
            Console.WriteLine("Introduceti 2 valori, a si b pentru care doriti sa creati o ecuatie de gradul I");
            string[] numere = Console.ReadLine().Split(' ');
            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);
            Console.WriteLine($"Ecuatia dumneavoastra este: {a}x + {b} ");
            float rezultat = (float)-b / a;

            Console.WriteLine($"Necunoscuta x are valoarea:  {-b}/{a}");
            Console.WriteLine($"Sau valoarea: {rezultat}");
        }
    }
}

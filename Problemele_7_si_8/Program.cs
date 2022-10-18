using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemele_7_si_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            P7();
            P8();
        }

        private static void P7()
        {
            int a, b;
            Console.Write("Dati doua valori pe care sa le inversati prin prima metoda: ");
            string[] numere = Console.ReadLine().Split(' ');
            a = int.Parse(numere[0]);  
            b= int.Parse(numere[1]);

            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Numerele inversate sunt: {a} {b}");

        }
        private static void P8()
        {
            int a, b;
            Console.Write("Dati doua valori pe care sa le inversati prin a doua metoda: ");
            string[] numere = Console.ReadLine().Split(' ');
            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);

            a = a + b;
            b = a - b;
            a= a - b;
            
            Console.WriteLine($"Numerele inversate sunt: {a} {b}");

        }
    }
}

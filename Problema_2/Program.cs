using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EcuatieDeGradul2();
        }

        private static void EcuatieDeGradul2()
        {
            int a, b, c;
            Console.WriteLine("Introduceti 3 valori, a, b, c pentru care doriti sa construiti ecuatia de gradul al doilea");
            string[] numere = Console.ReadLine().Split(' ');
            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);
            c = int.Parse(numere[2]);
            Console.WriteLine($"Ecuatia dumneavoastra are forma: {a}x^2 + {b}x + {c}");

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine($"Rezultatul obtinut este: ({-b} +/- i({Math.Sqrt(Math.Abs(delta))}))/{2 * a}");
            }
            else if (delta>0)
                Console.WriteLine($"Rezultatul obtinut este: ({-b} +/- {Math.Sqrt(Math.Abs(delta))})/{2 * a}");
            else Console.WriteLine($"Rezultatul obtinut este: ({-b})/{2 * a}");
        }
    }
}

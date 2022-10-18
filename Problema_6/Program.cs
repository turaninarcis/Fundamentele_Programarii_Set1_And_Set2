using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            P6();
        }

        private static void Enunt(bool afirmatie)
        {
            if(afirmatie)
                Console.WriteLine("Cele 3 valori pot fi lungimile unui triunghi");
            else Console.WriteLine("Cele 3 valori NU pot fi lungimile unui triunghi");
        }
        private static void P6()
        {
            int a, b, c;

            Console.WriteLine("Introduceti 3 valori, a, b si c pentru care sa aflati daca pot sa fie lungimile laturilor unui triunghi:");
            string[] numere = Console.ReadLine().Split(' ');
            a = int.Parse(numere[0]);
            b = int.Parse(numere[1]);
            c = int.Parse(numere[2]);

            if ((c >= a && c >= b) && c < (a + b))
                Enunt(true);
            else if ((a >= b && a >= c) && a < (c + b))
                Enunt(true);
            else if ((b >= a && b >= c) && b < (a + c))
                Enunt(true);
            else Enunt(false);
        }
    }
}

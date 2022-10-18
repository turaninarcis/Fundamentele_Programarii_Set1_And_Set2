using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divizibilitate();
        }

        private static void Divizibilitate()
        {
            int n, k;
            Console.WriteLine("Introduceti doua numere, n si k pentru a determina daca numarul n se divide cu k");
            string[] numere = Console.ReadLine().Split(' ');
            n= int.Parse(numere[0]);
            k= int.Parse(numere[1]);
            if (n % k == 0)
            {
                Console.WriteLine("n se divide cu k");

            }
            else Console.WriteLine("n nu se divide cu k");
        }
    }
}

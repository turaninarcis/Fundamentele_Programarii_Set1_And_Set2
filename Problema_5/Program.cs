using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            P5();
        }

        private static void P5()
        {
            Console.Write("Introduceti un numar ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti a cata cifra de la capatul numarului doriti sa aflati ");
            int k = int.Parse(Console.ReadLine());
            string numar = a.ToString();
            if(k>numar.Length)
            {
                Console.WriteLine("Nu se poate arata a k-a cifra de la capatul sirului deoarece k este mai mare decat numarul de cifre ale numarului");
            }
            else
            {
                int aux = a;
                for(int i = 1; i<k;i++)
                {
                    aux = aux / 10;
                }
                Console.WriteLine($"A k-a cifra a numarului de la capat este {aux % 10}");
            }
        }
    }
}

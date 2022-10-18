using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            An_Bisect();
        }

        private static void An_Bisect()
        {
            Console.WriteLine("Introduceti un an pentru a afla daca este an bisect sau nu");
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine($"Anul {a} este un an bisect");
            }
            else Console.WriteLine($"Anul {a} nu este un an bisect");
        }
    }
}

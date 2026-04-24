using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparador_de_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe N°1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe N°2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe N°3: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n2 > n3)
            {
                Console.WriteLine( n1 + " es mayor");
            }
            else
            {
                if (n2 > n1 && n1 > n3)
                {
                    Console.WriteLine( n2 + " es mayor");
                }
                else
                {
                    Console.WriteLine( n3 + " es mayor");
                }
            }

        }
    }
}

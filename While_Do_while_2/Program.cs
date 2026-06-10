using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generador_de_numero_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            Console.Write("Ingrese un número límite: ");
            int lim = int.Parse(Console.ReadLine());

            while (num <= lim)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }

                num++;
            }
        }
    }
}

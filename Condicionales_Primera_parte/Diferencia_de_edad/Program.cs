using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferencia_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Edad de hermano 1: ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Edad de hermano 2: ");
            int h2 = Convert.ToInt32(Console.ReadLine());
            if(h1>h2)
            {
                int calculo = h1 - h2;
                Console.WriteLine("El hermano 1 es el mayor y le gana al hermano 2 por " + calculo + " años");
            }
            else
            {
                if (h2>h1)
                {
                    int calculo_2 = h2 - h1;
                    Console.WriteLine("El hermano 2 es el mayor y le gana al hermano 1 por " + calculo_2 + " años");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_centena
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAcu = 0;
            int num = 0;
            int contador = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese un numero cualquiera:");
                num = int.Parse(Console.ReadLine());
                numAcu = numAcu + num;
                if (num > 100)
                {
                    contador++ ;
                }
            }

            Console.WriteLine("Ingreso " + contador + " veces un numero mayor a 100");
        }
    }
}

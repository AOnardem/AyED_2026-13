using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese un numero entero positivo: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Factores primos: ");
                Factores_Primos(num);
            }
        }

        static void Factores_Primos(int num)
        {
            int divi = 2;
            int can = 0;

            while (num > 1)
            {
                while (num % divi == 0)
                {
                    Console.Write(divi + " ");
                    num = num / divi;
                    can++;
                }

                divi++;
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad total de factores primos: " + can);
        }

    }
}

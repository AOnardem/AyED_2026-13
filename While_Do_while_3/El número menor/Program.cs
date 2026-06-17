using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_número_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un número positivo (negativo para finalizar): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                int minimo = numero;

                while (numero >= 0)
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                    Console.Write("Ingrese un número positivo (negativo para finalizar): ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("El número menor ingresado es: " + minimo);
            }
            else
            {
                Console.WriteLine("No se ingresaron números positivos.");
            }
        }
    }
}

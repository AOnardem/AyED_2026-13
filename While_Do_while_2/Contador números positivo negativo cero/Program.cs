using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_números_positivo_negativo_cero
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;
            int neg = 0;
            int ceros = 0;

            string entrada;

            while (true)
            {
                Console.Write("Ingrese un número: ");
                entrada = Console.ReadLine();

                if (entrada == "X")
                {
                    break;
                }

                int numero = int.Parse(entrada);

                if (numero > 0)
                {
                    pos++;
                }
                else if (numero < 0)
                {
                    neg++;
                }
                else
                {
                    ceros++;
                }
            }

            Console.WriteLine("Positivos: " + pos);
            Console.WriteLine("Negativos: " + neg);
            Console.WriteLine("Ceros: " + ceros);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_juego_de_Adivina_el_Número
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsec = 42;
            int intentos = 0;
            int num;

            do
            {
                Console.Write("Adivine el número: ");
                num = int.Parse(Console.ReadLine());

                intentos++;

                if (num < numsec)
                {
                    Console.WriteLine("El número es mayor");
                }
                else if (num > numsec)
                {
                    Console.WriteLine("El número es menor");
                }

            } while (num != numsec && intentos < 5);

            if (num == numsec)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste. El número era " + numsec);
            }

            Console.WriteLine("Intentos utilizados: " + intentos);
        

        }
    }
}

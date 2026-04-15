using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontras un Cristal Kyber perdido");
            Console.WriteLine("¿Que haces?");
            Console.WriteLine("1. Lo devuelves al templo");
            Console.WriteLine("2. Lo vendes por creditos");
            Console.WriteLine("3. Lo usas para construir un arma roja");
            Console.WriteLine("Ingrese una el numero de la opcion decidida: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1) 
            {
                Console.WriteLine("El camino del Jedi sigue ");
            }
            else 
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Un cazarrecompensas eres");
                }
                else
                {
                    if (opcion == 3)
                    {
                        Console.WriteLine("El Lado Oscuro se apodera de ti");
                    }
                    else
                    {
                        Console.WriteLine("Error en la Fuerza: opción inválida");
                    }

                }
            }

        }
    }
}

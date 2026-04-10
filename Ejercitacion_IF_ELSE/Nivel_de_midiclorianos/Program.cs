using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel_de_midiclorianos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de midiclorianos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad > 15000)
            {
                Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo");
            }
            else
            {
                if (cantidad >= 5000)
                {
                    Console.WriteLine("Aceptable para entrenamiento Padawan");
                }
                else
                {
                    Console.WriteLine("No posee sensibilidad a la Fuerza");
                }

            }

        }
    }
}

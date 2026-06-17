using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro_estadístico_de_edades__Censo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int mayores = 0;
            int menores = 0;
            int cantidad = 0;
            int suma = 0;

            Console.Write("Ingrese una edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            while (edad >= 0)
            {
                suma += edad;
                cantidad++;

                if (edad >= 18)
                    mayores++;
                else
                    menores++;

                Console.Write("Ingrese una edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }

            double promedio = (double)suma / cantidad;

            Console.WriteLine("Promedio de edad: " + promedio);
            Console.WriteLine("Mayores de edad: " + mayores);
            Console.WriteLine("Menores de edad: " + menores);

        }
    }
}

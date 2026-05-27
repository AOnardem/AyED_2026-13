using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_notas_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int nota;
            int suma = 0;
            Console.WriteLine("Ingrese 5 veces notassS ");
            while (contador <= 5)
            {
                Console.Write("Ingrese la nota " + contador + ": ");
                nota = int.Parse(Console.ReadLine());
                suma = suma + nota;
                contador++;
            }
            int promedio = suma / 5;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}

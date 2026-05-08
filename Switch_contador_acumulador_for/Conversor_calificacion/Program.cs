using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_calificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estas son las opciones a tomar:");
            Console.WriteLine("1. A");
            Console.WriteLine("2. B");
            Console.WriteLine("3. C");
            Console.WriteLine("4. D");
            Console.WriteLine("5. F");
            Console.Write("Coloque la opcion deciada: ");
            int nota = int.Parse(Console.ReadLine());
            switch (nota)
            {
                case 1:
                    Console.WriteLine("La nota decidida es Excelente");
                    break;
                case 2:
                    Console.WriteLine("La nota decidida es Bueno");
                    break;
                case 3:
                    Console.WriteLine("La nota decidida es Regular");
                    break;
                case 4:
                    Console.WriteLine("La nota decidida es Suficiente");
                    break;
                case 5:
                    Console.WriteLine("La nota decidida es Reprobado");
                    break;
                default:
                    Console.WriteLine("La opcion elegida no es valida");
                    break;
            }
        }
    }
}

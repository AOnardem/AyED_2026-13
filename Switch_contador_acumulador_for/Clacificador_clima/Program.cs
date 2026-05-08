using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clacificador_clima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estas son las opciones a tomar:");
            Console.WriteLine("1. primavera");
            Console.WriteLine("2. verano");
            Console.WriteLine("3. otoño");
            Console.WriteLine("4. invierno");
            Console.Write("Coloque la opcion deciada: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("La opcion elegida es primavera");
                    break;
                case 2:
                    Console.WriteLine("La opcion elegida es verano");
                    break;
                case 3:
                    Console.WriteLine("La opcion elegida es otoño");
                    break;
                case 4:
                    Console.WriteLine("La opcion elegida es invierno");
                    break;
                default:
                    Console.WriteLine("La opcion elegida no es valida");
                    break;
            }



        }
    }
}

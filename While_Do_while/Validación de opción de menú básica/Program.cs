using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validación_de_opción_de_menú_básica
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
         
            do
            {
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1. Saludar ");
                Console.WriteLine("2. Despedirse ");
                Console.WriteLine("3. Salir ");
                Console.Write("Ingre la opcion deciada: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1 )
                {
                    Console.WriteLine("Hola, como esta??");
                }
                if (op == 2)
                {
                    Console.WriteLine("Nos vemos luego");
                }

            } while (op != 3);
        }
    }
}

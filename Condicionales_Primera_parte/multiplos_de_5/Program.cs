using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero % 5;
            if (resultado == 0)
            {
                Console.WriteLine("El numero que puso es multiplo de 5");
            }
            else
            {
                Console.WriteLine("El numero que puso no es multiplo de 5");
            }
        }
    }
}

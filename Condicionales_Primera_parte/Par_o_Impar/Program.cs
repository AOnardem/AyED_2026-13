using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero para ver si es par o impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero % 2;
            if (resultado == 0)
            {
                Console.WriteLine("Su numero es par");
            }
            else
            {
                Console.WriteLine("Su numero es impar");
            }
        }
    }
}

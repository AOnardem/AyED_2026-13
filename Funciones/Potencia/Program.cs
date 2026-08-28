using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero como base: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero como exponente: ");
            int po = Convert.ToInt32(Console.ReadLine());
            int resul = potencia(num, po);
            Console.WriteLine("El resultado es: " + resul);
        }

        static int potencia (int num, int po)
        {
            int resul = 1;
            for (int i = 0; i < po; i++)
            {
                resul = resul * num;
            }
            return resul;
        }
    }
}

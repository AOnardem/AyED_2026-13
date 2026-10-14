using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (Capicua(num))
            {
                Console.WriteLine("El numero es capicua.");
            }
            else
            {
                Console.WriteLine("El numero no es capicua.");
            }

            Console.WriteLine("Cantidad de digitos: " + Can_Digitos(num));
        }

        static bool Capicua(int num)
        {
            int or = num;
            int inver = 0;

            if (num < 0)
            {
                num = num * -1;
                or = num;
            }

            while (num > 0)
            {
                int dig = num % 10;
                inver = inver * 10 + dig;
                num = num / 10;
            }

            return or == inver;
        }

        static int Can_Digitos(int num)
        {
            if (num < 0)
            {
                num = num * -1;
            }

            if (num == 0)
            {
                return 1;
            }

            int can = 0;

            while (num > 0)
            {
                can++;
                num = num / 10;
            }

            return can;
        }

    }
}

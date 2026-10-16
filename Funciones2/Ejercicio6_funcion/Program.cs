using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros: ");
            int can = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[can];

            for (int i = 0; i < can; i++)
            {
                Console.Write("Ingrese un numero: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool existe;
            int segun = SegundoMayor(num, out existe);

            if (existe)
            {
                Console.WriteLine("El segundo numero mas grande es: " + segun);
            }
            else
            {
                Console.WriteLine("No existe un segundo valor diferente al mayor.");
            }
        }

        static int SegundoMayor(int[] num, out bool existe)
        {
            int may = num[0];
            int segun = 0;
            existe = false;

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > may)
                {
                    segun = may;
                    may = num[i];
                    existe = true;
                }
                else if (num[i] < may)
                {
                    if (!existe || num[i] > segun)
                    {
                        segun = num[i];
                        existe = true;
                    }
                }
            }

            return segun;
        }
    }
}

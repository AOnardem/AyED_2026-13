using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            mostrar_num_com(num1, num2);
        }
     
        static void mostrar_num_com(int num1, int num2)
        {
            int par = 0;
            int imp = 0;
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
                sum += i;

                if (i % 2 == 0)
                {
                    par++;
                }
                else
                {
                    imp ++;
                }
            }

            Console.WriteLine("Cantidad de pares: " + par);
            Console.WriteLine("Cantidad de impares: " + imp);
            Console.WriteLine("Suma: " + sum);
        }
    }
}

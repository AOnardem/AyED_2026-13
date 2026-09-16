using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_funcion
{
    class Program
    {
            static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int may = 0;
            int men = 0;
            int sum = 0;
            Console.Write("Ingrese la cantidad de numeros que desea: ");
            int can_num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < can_num; i++)
            {
                Console.Write("Ingrese el numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                if (i == 0)
                {
                    may = num;
                    men= num;
                }
                else
                {
                    may = mayor(num, may);
                    men = menor(num, men);
                }
                par_impar(num, ref par, ref impar);
            }
            promedio(sum, can_num);
            Console.WriteLine("El mayor es: " + may);
            Console.WriteLine("El menor es: " + men);
            Console.WriteLine("Cantidad de numeros pares: " + par);
            Console.WriteLine("Cantidad de numeros impares: " + impar);
        }

            static void par_impar(int num, ref int par, ref int impar)
        {
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
        }

            static void promedio (int sum, int can_num)
        {
            double pro = (double)sum / can_num;
            Console.WriteLine("El promedio es: " + pro);
        }
            static int mayor (int num, int may)
        {
            if (num > may)
            {
                may = num;
            }

            return may;
        }
            static int menor (int num, int men)
        {
            if (num < men)
            {
                men = num;
            }

            return men;
        }
      }
    }

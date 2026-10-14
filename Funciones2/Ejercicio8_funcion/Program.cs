using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer extremo: ");
            int ini = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo extremo: ");
            int fin = Convert.ToInt32(Console.ReadLine());

            Mostrar_Primos(ini, fin);        
        }

        static bool Primo(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Mostrar_Primos(int ini, int fin)
        {
            int can = 0;

            if (ini > fin)
            {
                int aux = ini;
                ini = fin;
                fin = aux;
            }

            for (int i = ini; i <= fin; i++)
            {
                if (Primo(i))
                {
                    Console.WriteLine(i);
                    can++;
                }
            }

            Console.WriteLine("Cantidad de numeros primos: " + can);
        }

    }
}

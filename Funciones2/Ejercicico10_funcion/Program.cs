using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicico10_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Suma(num);
        }

        static void Suma (int num)
        {
            bool enc = false;

            for (int inicio = 1; inicio < num; inicio++)
            {
                int suma = 0;
                int siguiente = inicio;

                while (suma < num)
                {
                    suma += siguiente;

                    if (suma == num)
                    {
                        enc = true;

                        Console.Write(num + " = ");

                        for (int i = inicio; i <= siguiente; i++)
                        {
                            Console.Write(i);

                            if (i < siguiente)
                            {
                                Console.Write(" + ");
                            }
                        }

                        Console.WriteLine();
                    }

                    siguiente++;
                }
            }

            if (!enc)
            {
                Console.WriteLine("El numero no puede representarse como suma de numeros consecutivos.");
            }
        }

    }
}

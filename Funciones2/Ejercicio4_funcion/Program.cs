using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_funcion
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.Write("Ingrese cuantos numeros quiere ingresar: ");
            int can = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[can];

            for (int i = 0; i < can; i++)
            {
                Console.Write("Ingrese un numero: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Positivos: " + Pos(num));
            Console.WriteLine("Negativos: " + Neg(num));
            Console.WriteLine("Ceros: " + Ceros(num));
            Console.WriteLine("Promedio positivos: " + Prome_Pos(num));
            Console.WriteLine("Promedio negativos: " + Pro_Neg(num));

        }

        static int Pos(int[] num)

    {

                int can = 0;
                for (int i = 0; i < num.Length; i++)
                {

                    if (num[i] > 0)
                    {
                        can++;
                    }

                }
                return can;

        }

            static int Neg(int[] num)
        {
                int can = 0;
                for (int i = 0; i < num.Length; i++)
                {

                    if (num[i] < 0)
                    {
                        can++;
                    }

                }
                return can;

        }
            static int Ceros(int[] num)
        {
                int can = 0;
                for (int i = 0; i < num.Length; i++)

                {

                    if (num[i] == 0)

                    {
                        can++;
                    }

                }
                return can;
         }
            static double Prome_Pos(int[] num)
         {
                int sum = 0;
                int can = 0;


                for (int i = 0; i < num.Length; i++)
                {

                    if (num[i] > 0)

                    {

                        sum += num[i];
                        can++;

                    }

                }


                if (can == 0)

                    return 0;


                return (double)sum/ can;

          }
            static double Pro_Neg(int[] num)
          {

                int sum = 0;
                int can = 0;


                for (int i = 0; i < num.Length; i++)
                {

                    if (num[i] < 0)
                    {

                        sum += num[i];
                        can++;

                    }

                }

                if (can== 0)
            {
                return 0;
            }
                return (double)sum / can; 
            }
        }
    }

 

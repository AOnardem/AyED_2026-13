using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_semanal_de_temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un centro meteorológico registra la temperatura máxima de cada día de la semana(7 valores).
            El programa debe permitir cargar las 7 temperaturas y luego mostrar: la temperatura más alta de
            la semana, la más baja, y el promedio semanal.*/

            double[] tem = new double[7];
            double tmayor = 0;
            double tmenor = 0;
            double suma = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Ingrese la temperatura de la semana N° " + (i+1) + (" : "));
                tem[i] = double.Parse(Console.ReadLine());

                suma += tem[i];
            }

            tmayor = tem[0];
            tmenor = tem[0];

            for (int i = 1; i < 7; i++)
            {
                if (tem[i] > tmayor)
                    tmayor = tem[i];

                if (tem[i] < tmenor)
                    tmenor = tem[i];
            }
            double pro = suma / 7;
            Console.WriteLine("La temperatura mas alta fue: " + tmayor);
            Console.WriteLine("La temperatura mas baja fue: " + tmenor);
            Console.WriteLine("Promedio: " + pro);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_asistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] asis = new int [20];
            int inas = 0;
            Console.WriteLine("Ponga 1 si es asistencia o de lo contrario ponga 0 para inasistencia");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese 1 o 0: ");
                asis[i] = int.Parse(Console.ReadLine());
                if (asis[i] == 0)
                {
                    inas++;
                }
            }
            Console.WriteLine("Total de inasistencias: " + inas);
            if (inas >= 6)
            {
                Console.WriteLine("Libre por inasistencias");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}

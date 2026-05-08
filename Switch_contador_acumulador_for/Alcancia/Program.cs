using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int ahorroAcu = 0;
            int ahorro = 0;
            for (int i=1 ; i<=4 ; i++)
            {
                Console.Write("Ingrese el ahorro de la semana N° " + i + ":");
                ahorro = int.Parse(Console.ReadLine());
                ahorroAcu = ahorroAcu + ahorro;
            }
            Console.WriteLine("El dinero acumulado en el mes es de " + ahorroAcu);
        }
    }
}

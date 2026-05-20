using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador_hasta_el_Cero
{
    class Program
    {
        static void Main(string[] args)
        {
            int ahorroAcu = 0;
            int ahorro = 0;
            do
            {
                Console.Write("Ingrese numero entero para sumar: ");
                ahorro = int.Parse(Console.ReadLine());
                ahorroAcu = ahorroAcu + ahorro;
            } while (ahorro > 0 || ahorro < 0) ;
            Console.WriteLine("El total acumulado es " + ahorroAcu);
        }
    }
}

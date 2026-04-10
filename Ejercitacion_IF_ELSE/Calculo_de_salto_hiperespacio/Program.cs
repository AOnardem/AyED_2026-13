using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_salto_hiperespacio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba la distacia al destino (en años luz): ");
            int distancia = Convert.ToInt32(Console.ReadLine());//10
            Console.Write("Escriba la cantidad de conbustible: ");//120
            int conbustible = Convert.ToInt32(Console.ReadLine());
            int can_l_v = distancia * 12;

            if (conbustible >= can_l_v) 
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }

            else
            {
                int can_a_bajar = can_l_v - conbustible;
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + can_a_bajar + " litros");
            }

        }
    }
}

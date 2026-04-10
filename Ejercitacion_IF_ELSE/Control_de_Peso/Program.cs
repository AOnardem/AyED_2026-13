using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe cual es el peso actual: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado. Buen viaje, Mando");
            }
            else
            {
                int peso_quitar = peso - 5000;
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + peso_quitar + " kg para despegar");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento_ChiquiTapia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de minutos que se quedo el vehiculo: ");
            int min = Convert.ToInt32(Console.ReadLine()); //130
            int convercion_hora = min / 60;
            int convercion_min = min % 60;
            int costo_total_h = convercion_hora * 6000;
            int costo_total_m = convercion_min * 150;
            int costo_final = costo_total_h + costo_total_m;
            int porcentaje = 21;
            int iva = costo_final * porcentaje / 100;
            int monto_final = iva + costo_final;
            Console.WriteLine("El monto a pagar es de: " + monto_final);


        }
    }
}

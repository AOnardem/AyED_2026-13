using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Descuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cual fue el monto de la compra?: ");
            int monto = Convert.ToInt32(Console.ReadLine());
            if (monto > 5000)
            {
                int porcentaje = 15;
                int descuento = monto * porcentaje / 100;
                int total = monto - descuento;
                Console.WriteLine("El monto final con el 15% de descuento es de: " + total);
            }
            else
            {
                Console.WriteLine("El monto final es: " + monto);
            }
        }
    }
}

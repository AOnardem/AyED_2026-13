using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aumento_salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su sueldo: ");
            int sueldo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba sus años de antiguedad: ");
            int años = Convert.ToInt32(Console.ReadLine());
            if (años > 10)
            {
                int porcentaje = 20;
                int descuentos = sueldo * porcentaje / 100;
                int montof = sueldo + descuentos;
                Console.WriteLine("El sueldo nuevo es de " + montof);
            }
            else
            {
                int porcentaje2 = 5;
                int descuento2 = sueldo + porcentaje2;
                int montof2 = sueldo + descuento2;
                Console.WriteLine("El sueldo nuevo es de " + montof2);
                      
            }

        }
    }
}

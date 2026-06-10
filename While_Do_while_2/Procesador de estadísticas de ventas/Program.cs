using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesador_de_estadísticas_de_ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int venm = 0;
            int canv = 0;
            char con;

            do
            {
                Console.Write("Ingrese monto de la venta: ");
                int venta = int.Parse(Console.ReadLine());

                total += venta;
                canv++;

                if (venta > venm)
                {
                    venm = venta;
                }

                Console.Write("¿Desea ingresar otra venta? (S/N): ");
                con = char.Parse(Console.ReadLine());

            } while (con == 'S');

            Console.WriteLine("Total recaudado: " + total);
            Console.WriteLine("Cantidad de ventas: " + canv);
            Console.WriteLine("Venta más alta: " + venm);
        }
    }
}

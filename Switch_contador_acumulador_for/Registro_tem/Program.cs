using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_tem
{
    class Program
    {
        static void Main(string[] args)
        {
            int temAcu = 0;
            int tem = 0;
            int contador = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Ingrese la temperatura del dia N° " + i + ": ");
                tem = int.Parse(Console.ReadLine());
                temAcu = temAcu + tem;
                if (tem < 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("Fuero " + contador + " dias de la semana que la temperatura fue menor a 0");
            Console.WriteLine("Y la suma de todas las temperaturas es " + temAcu);
        }
    }
}

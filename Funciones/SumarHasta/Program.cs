using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumarHasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            int resul = suma_hasta(num);
            Console.WriteLine("La suma es: " + resul);
        }
        static int suma_hasta(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}

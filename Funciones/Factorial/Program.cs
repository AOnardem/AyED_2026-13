using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero mayor o igual a 0: ");
            int num = int.Parse(Console.ReadLine());
            int resul = suma_hasta(num);
            Console.WriteLine("La factorizacion es: " + resul);
        }
        static int suma_hasta(int num)
        {
            int mul = 1;
            for (int i = 1; i <= num; i++)
            {
                mul = mul * i;
            }
            return mul;
        }
    }
}

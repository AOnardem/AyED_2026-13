using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicación_por_sumas_sucesivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int con = 0;
            Console.Write("escriba un el primer numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("escriba un el segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            while (con < b)
            {
                res = res + a;
                con++;
            }
            Console.WriteLine("Resultado: " + res);
        }
    }
}

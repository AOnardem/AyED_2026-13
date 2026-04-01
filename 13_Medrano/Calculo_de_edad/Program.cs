using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Que año naciste?: ");
            int año = Convert.ToInt32(Console.ReadLine());
            int edad = 2026 - año;
            Console.WriteLine("Si naciste en el año " + año + " tu edad al comienzo del año es de " + edad + " año ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_bancas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su promedio: ");
            int pro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba su distancia: ");
            int dis = Convert.ToInt32(Console.ReadLine());
            if (pro > 8 || dis > 50)
            {
                Console.WriteLine("Beca conceguida");
            }
        }
    }
}

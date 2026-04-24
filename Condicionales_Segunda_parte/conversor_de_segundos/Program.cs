using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_de_segundos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba una cantidad de segundos: ");
            int seg = Convert.ToInt32(Console.ReadLine());
            int min = seg / 60;
            int segundos = seg % 60;
            if (seg > 60)
            {
                Console.WriteLine("Son " + min + " minutos con " + segundos + " segundos");
            }
            else
            {
                Console.WriteLine("Son " + seg + " segundos");
            }
        }
    }
}

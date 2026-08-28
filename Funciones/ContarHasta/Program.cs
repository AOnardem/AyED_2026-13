using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarHasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            contador_hasta(num);
        }
        static void contador_hasta (int num)
        {
            int cont = 1;
            while (cont <= num)
            {
                Console.WriteLine(cont);
                cont++; 
            }
        }
    }
}

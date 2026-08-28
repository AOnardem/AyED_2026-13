using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarRegresivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            cuenta_regresiva(num);
        }

        static void cuenta_regresiva(int num)
        {
            while(num >= 1)
            {
                Console.WriteLine(num);
                num--;
            }
        }
    }
}

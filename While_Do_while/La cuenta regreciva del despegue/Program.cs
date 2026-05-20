using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_cuenta_regreciva_del_despegue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero positivo: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuenta regresiva: ");
            while (num >= 0)
            {
                Console.WriteLine( num);
                num--;
            }

        }
    }
}

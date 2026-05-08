using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iDIOMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opciones: ");
            Console.WriteLine("1. Ingles ");
            Console.WriteLine("2. Frances ");
            Console.WriteLine("3. Aleman ");
            Console.Write("Ingre la opcion deciada: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Salut");
                    break;
                case 3:
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }
        }
    }
}

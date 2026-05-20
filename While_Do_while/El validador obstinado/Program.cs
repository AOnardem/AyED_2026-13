using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_validador_obstinado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("La nota es: ");
            int num = int.Parse(Console.ReadLine());
            if ( num > 10)
            {
                do
                {
                    Console.Write("ERROR intentelo otra vez: ");
                    num = int.Parse(Console.ReadLine());

                } while (num < 1 || num > 10);
                Console.WriteLine("La nota es valida " + num);
            }
           
        }
    }
}

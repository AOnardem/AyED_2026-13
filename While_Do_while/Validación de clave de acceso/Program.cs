using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validación_de_clave_de_acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la clave de acceso: ");
           string clave = (Console.ReadLine());
            if (clave != "BL")
            {
                do
                {
                    Console.Write("ERROR intentelo otra vez: ");
                    clave = (Console.ReadLine());
                } while (clave != "BL");
            }
            Console.WriteLine("Acceso Permitido :)" );
        }
    }
}

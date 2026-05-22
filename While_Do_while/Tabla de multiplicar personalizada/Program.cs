using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar_personalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.Write("Ingrese el numero: ");
            int num = int.Parse(Console.ReadLine()); 
            while (cont <= 12 )
            {
                Console.WriteLine(num + " x " +  cont + (" = ") + num * cont);
                cont++; 
            } 

        }
    }
}

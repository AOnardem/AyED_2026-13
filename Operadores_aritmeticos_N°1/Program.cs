using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_aritmeticos_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un valor: ");
            int valor_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe un valor: ");
            int valor_2 = Convert.ToInt32(Console.ReadLine());
            int suma = valor_1 + valor_2;
            int resta = valor_1 - valor_2;
            int multi = valor_1 * valor_2;
            int divicion = valor_1 / valor_2;
            Console.WriteLine("El resultado de la suma de los dos valores es: " + suma + ". El resultado de la resta de los dos valores es: " + resta + ". El resultado de la multiplicación de los dos valores es: " + multi + ". El resultado de la divicion de los dos valores es: " + divicion);
        }
    }
}

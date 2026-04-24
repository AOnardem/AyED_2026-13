using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su peso: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            int IMC = peso / (altura * 2);
            if (IMC > 25)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Rango Normal");
            }

        }
    }
}

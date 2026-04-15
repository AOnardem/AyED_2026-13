using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima_de_la_Montaña
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba cual es la temperatura actual de la montaña: ");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura <= 0)
            {
                Console.WriteLine("Peligro de congelamiento");
            }
            else
            {
                if (temperatura <= 15)
                {
                    Console.WriteLine("Mucho frío");
                }
                else
                {
                    if (temperatura > 15)
                    {
                        Console.WriteLine("Clima agradable");
                    }
                }
            }
        }
    }
}

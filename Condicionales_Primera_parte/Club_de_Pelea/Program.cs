using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_de_Pelea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su nombre: ");
            String nombre = Console.ReadLine(); 
            Console.Write("Escriba su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al club, " + nombre);
            }
            else
            {
                 Console.WriteLine("Lo siento, eres muy polluelo para esto");
                
            }
        }
    }
}

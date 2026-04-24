using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jubilacion_anticipada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su genero (F/M) : ");
            String genero = Console.ReadLine();
            Console.Write("Escriba su edad : ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (genero == "F" && edad >= 60 || genero == "M" && edad >= 65)
            {
                Console.WriteLine("Puede iniciar el tramite jubilatorio");
            }
            else
                {
                    Console.WriteLine("No puede iniciar el tramite jubilatorio");
                }
        }
    }
}

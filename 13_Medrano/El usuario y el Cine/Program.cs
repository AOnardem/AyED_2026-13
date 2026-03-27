using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_usuario_y_el_Cine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string pelicula_fav;
            Console.WriteLine("Hola usuario");
            Console.Write("¿Como te llama?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tun pelicula favorita?: ");
            pelicula_fav = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ".Tu pelicula preferida " + pelicula_fav + " es una porqueria");
                
        }
    }
}

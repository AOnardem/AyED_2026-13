using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_usuario_y_los_juegos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string juego;
            string consola;
            Console.WriteLine("Hola usuario");
            Console.Write("¿Como te llamas?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu juego favorito?: ");
            juego = Console.ReadLine();
            Console.Write("¿en que consola se juega?: ");
            consola = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ". Tu juego favorito es " + juego + " y se juega en " + consola);
        }
    }
}

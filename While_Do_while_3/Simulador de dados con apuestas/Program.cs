using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_dados_con_apuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditos = 100;
            int apuesta;
            int dad1;
            int dad2;
            int suma;

            do
            {
                Console.WriteLine("Créditos disponibles: " + creditos);

                Console.Write("Ingrese su apuesta: ");
                apuesta = int.Parse(Console.ReadLine());
                if (apuesta == 0)
                {
                    break;
                }                  

                if (apuesta > creditos || apuesta < 0)
                {
                    Console.WriteLine("Apuesta inválida.");
                }

                Console.Write("Ingrese el valor del dado 1: ");
                dad1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor del dado 2: ");
                dad2 = int.Parse(Console.ReadLine());

                suma = dad1 + dad2;

                if (suma == 7 || suma == 11)
                {
                    creditos += apuesta * 2;
                    Console.WriteLine("Ganaste");
                }
                else
                {
                    creditos -= apuesta;
                    Console.WriteLine("Perdiste");
                }

            } while (creditos != 0 );

            Console.WriteLine("Saldo final: " + creditos);

        }
    }
}

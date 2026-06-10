using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cajero_Automático_Simulado
{
    class Program
    {
        static void Main(string[] args)
        {
            int canp = 10000;
            int op;
            do
            {
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1. Depositar dinero ");
                Console.WriteLine("2. Retirar dinero ");
                Console.WriteLine("3. Ver saldo actual ");
                Console.WriteLine("4. Salir ");
                Console.Write("Eliga una opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad que quiere ingresar: ");
                        int cani = int.Parse(Console.ReadLine());
                        canp = canp + cani;
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad que quiere retirar: ");
                        int canr = int.Parse(Console.ReadLine());
                        canp = canp - canr;
                        break;
                    case 3:
                        Console.WriteLine("Su saldo acual es: " + canp);
                        break;
                }

            } while (op != 4);




        }
    }
}

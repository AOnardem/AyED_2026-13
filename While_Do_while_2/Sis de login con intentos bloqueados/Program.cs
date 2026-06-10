using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_de_login_con_intentos_bloqueados
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuco = "admin";
            string conco = "1234";

            int intentos = 0;

            while (intentos < 3)
            {
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuario == usuco && contraseña == conco)
                {
                    Console.WriteLine("Bienvenido al sistema.");
                }

                intentos++;
            }

            if (intentos == 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad.");
            }
        }
    }
}

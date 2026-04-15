using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_Contraseña
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su usuario: ");
            String usuario = Console.ReadLine();
            Console.Write("Escriba su contraceña: ");
            String contraseña = Console.ReadLine();
            if (usuario == "admin")
            {
                if(contraseña == "1234")
                {
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    Console.WriteLine("Error de credenciales"); 
                }
  
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_asistencia_y_porcentaje
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string estado;
            string continuar;
            int presentes = 0;
            int ausentes = 0;
            int total;

            do
            {
                Console.Write("Nombre del alumno: ");
                nombre = Console.ReadLine();

                Console.Write("Estado (Presente o Ausente): ");
                estado = Console.ReadLine();

                if (estado == "P")
                    presentes++;
                else if (estado == "A")
                    ausentes++;

                Console.Write("¿Desea cargar otro alumno? (S/N): ");
                continuar = Console.ReadLine();

            } while (continuar == "S");

            total = presentes + ausentes;

            double porcentaje = (double)presentes * 100 / total;

            Console.WriteLine("Presentes: " + presentes);
            Console.WriteLine("Ausentes: " + ausentes);
            Console.WriteLine("Porcentaje de presentismo: " + porcentaje);

        }
    }
}

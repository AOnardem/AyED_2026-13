using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla_de_calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un docente tiene un curso de 10 alumnos. El programa debe permitir cargar las 10 notas 
            (valores de 1 a 10) y luego mostrar cuántos alumnos aprobaron (nota mayor o igual a 6), 
            cuántos desaprobaron, y el promedio general del curso.*/


            int[] notas = new int[10];
            int apro = 0;
            int des = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese la nota: ");
                notas[i] = int.Parse(Console.ReadLine());
                sum += notas[i];
                if (notas[i] >= 6)
                {
                    apro++;
                }

                else
                {
                    des++;
                }
            }
            int pro = sum / 10;
            Console.WriteLine("Cantidad de alumnos aprobados: " + apro);
            Console.WriteLine("Cantidad de alumnos desaprobados: " + des);
            Console.WriteLine("Promedio del aula: " + pro);
        }
    }
}

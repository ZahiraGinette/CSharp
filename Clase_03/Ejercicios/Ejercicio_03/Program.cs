using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            // Crear tres instancias de la clase Estudiante
            Estudiante estudiante1 = new Estudiante("Juan", "Perez", "1001");
            Estudiante estudiante2 = new Estudiante("María", "González", "1002");
            Estudiante estudiante3 = new Estudiante("Pedro", "Rodríguez", "1003");

            // Cargar las notas del primer y segundo parcial a todos los alumnos
            estudiante1.SetNotaPrimerParcial(7);
            estudiante1.SetNotaSegundoParcial(8);

            estudiante2.SetNotaPrimerParcial(5);
            estudiante2.SetNotaSegundoParcial(6);

            estudiante3.SetNotaPrimerParcial(3);
            estudiante3.SetNotaSegundoParcial(4);

            // Mostrar los datos de todos los alumnos
            Console.WriteLine("Datos del estudiante 1:");
            Console.WriteLine(estudiante1.Mostrar());

            Console.WriteLine("\nDatos del estudiante 2:");
            Console.WriteLine(estudiante2.Mostrar());

            Console.WriteLine("\nDatos del estudiante 3:");
            Console.WriteLine(estudiante3.Mostrar());

            Console.ReadLine();
        }
    }
}

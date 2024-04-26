using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            // Instanciar objetos de tipo Persona
            Persona persona1 = new Persona("Juan", new DateTime(1990, 5, 15), 12345678);
            Persona persona2 = new Persona("María", new DateTime(2005, 8, 20), 87654321);
            Persona persona3 = new Persona("Pedro", new DateTime(2015, 3, 10), 15975364);

            // Mostrar información de las personas y si son mayores de edad o no
            Console.WriteLine("Información de las personas:");
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());

            Console.WriteLine();

            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Console.WriteLine();

            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());

            Console.ReadLine();

        }
    }
}

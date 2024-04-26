using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escribir un programa que determine si un año es bisiesto.
             * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 
             * no son bisiestos, salvo si ellos también son múltiplos de 400. 
             * Por ejemplo: el año 2000 es bisiesto, pero 1900 no.
             * Pedirle al usuario un año de inicio y otro de fin y mostrar 
             * todos los años bisiestos en ese rango. */

            Console.Title = "Ejercicio Nro 06";

            Console.WriteLine("Ingrese el año de inicio:");
            string inputInicio = Console.ReadLine();

            Console.WriteLine("Ingrese el año de fin:");
            string inputFin = Console.ReadLine();

            int añoInicio, añoFin;

            if (!int.TryParse(inputInicio, out añoInicio) || !int.TryParse(inputFin, out añoFin))
            {
                Console.WriteLine("Por favor, ingresa años válidos.");
                return;
            }

            Console.WriteLine("Años bisiestos entre " + añoInicio + " y " + añoFin + ":");

            for (int año = añoInicio; año <= añoFin; año++)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.WriteLine(año);
                }
            }

            Console.ReadKey();
        }
    }
}

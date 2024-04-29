using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un programa que sume números enteros hasta que el usuario lo 
             * determine por medio de un mensaje "¿Desea continuar? (S/N)".
             * Crear la clase Validador y el método estático ValidarRespuesta, 
             * que validará el ingreso de respuestas.
             * El método devolverá un valor de tipo booleano, TRUE si se 
             * ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

            Console.Title = "Ejercicio Nro 02";

            char respuesta;
            int number;
            int acumulador = 0;
            Console.Write("Ingrese el primer numero: ");
            int.TryParse(Console.ReadLine(), out number);
            acumulador = acumulador + number;
            do
            {
                Console.Write("\nIngrese el siguiente numero a sumar: ");
                int.TryParse(Console.ReadLine(), out number);
                acumulador = acumulador + number;
                Console.Write("\nContinua? S/N: ");
                respuesta = Console.ReadKey().KeyChar;
            } while (ValidarRespuesta.Validar(respuesta));
            Console.WriteLine("\n\nTotal: {0}", acumulador);
            Console.ReadKey();
        }
    }
}

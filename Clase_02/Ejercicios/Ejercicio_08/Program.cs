using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un método estático que reciba una fecha y calcule el número 
             * de días que pasarondesde esa fecha hasta la fecha actual. Tener 
             * en cuenta los años bisiestos.
             * Pedir por consola la fecha de nacimiento de una persona (día, mes y año) 
             * y calcule el número de días vividos por esa persona hasta 
             * la fecha actual utilizando el método desarrollado anteriormente.
             * Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.*/

            Console.Title = "Ejercicio Nro 08";
            Console.WriteLine("Ingrese la fecha de nacimiento (formato: dd/mm/yyyy):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                int diasVividos = CalcularDiasVividos(fechaNacimiento);
                Console.WriteLine($"Número de días vividos hasta la fecha actual: {diasVividos} días");
            }
            else
            {
                Console.WriteLine("Error: Fecha de nacimiento inválida.");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Calcula el número de días vividos desde la fecha de nacimiento hasta la fecha actual.
        /// </summary>
        /// <param name="fechaNacimiento">La fecha de nacimiento de la persona.</param>
        /// <returns>El número de días vividos.</returns>
        static int CalcularDiasVividos(DateTime fechaNacimiento)
        {
            TimeSpan diferencia = DateTime.Now - fechaNacimiento;
            return diferencia.Days;
        }
    }
}

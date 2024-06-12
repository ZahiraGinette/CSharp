using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Lambda_sintaxis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Llamada al método
            Saludar("Juan", "Pérez");

            // Con una expresion lambda
            Action<string, string> saludarLambda = (nombre, apellido) =>
            {
                string saludo = $"¡Bienvenido {nombre} {apellido}!!";
                Console.WriteLine(saludo);
            };

            // Llamada a la expresión lambda
            saludarLambda("María", "González");

            Console.ReadKey();
        }

        // Con un metodo
        public static void Saludar(string nombre, string apellido)
        {
            string saludo = $"¡Bienvenido {nombre} {apellido}!";
            Console.WriteLine(saludo);
        }
 
 

    }
}

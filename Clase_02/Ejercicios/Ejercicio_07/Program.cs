using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear una aplicación de consola que pida al usuario ingresar la base y 
             * la altura de un triángulo en centímetros.
             * El programa deberá calcular la longitud de la hipotenusa aplicando 
             * el teorema de pitágoras y usar los métodos Pow y Sqrt de la clase 
             * Math para realizar los cálculos.
             * Mostrar el resultado en la consola.*/

            Console.Title = "Ejercicio Nro 07";

            Console.WriteLine("Ingrese la base del triángulo en centímetros:");
            double baseTriangulo = ObtenerNumeroIngresado();

            Console.WriteLine("Ingrese la altura del triángulo en centímetros:");
            double alturaTriangulo = ObtenerNumeroIngresado();

            double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"La longitud de la hipotenusa es: {hipotenusa} centímetros");

            Console.ReadLine(); 
        }

        /// <summary>
        /// Obtiene un número ingresado por el usuario, validando que sea positivo.
        /// </summary>
        /// <returns>El número ingresado.</returns>
        static double ObtenerNumeroIngresado()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
            }
            return numero;
        }

        /// <summary>
        /// Calcula la hipotenusa de un triángulo utilizando el teorema de Pitágoras.
        /// </summary>
        /// <param name="baseTriangulo">La base del triángulo.</param>
        /// <param name="alturaTriangulo">La altura del triángulo.</param>
        /// <returns>La longitud de la hipotenusa.</returns>
        static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            return hipotenusa;
        }
    }
}

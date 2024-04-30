using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            // Probando la clase Sumador
            Sumador sumador1 = new Sumador();
            long resultado = sumador1.Sumar(5, 3); // La suma de 5 y 3 es: 8
            string concatenar = sumador1.Sumar("Hola ", "mundo!"); // La concatenación de "Hola " y "mundo" es: Hola mundo

            // Conversión explícita
            Console.WriteLine($"Resultado de la suma: {resultado}");
            Console.WriteLine($"Resultado de la concatenacion: {concatenar}");


            Console.WriteLine($"Cantidad de sumas de sumador 1: {sumador1.Cantidad}"); // Cantidad de sumas: 2

            // Sobrecarga del operador +
            Sumador sumador2 = new Sumador(5);
            long resultadoSuma = sumador1 + sumador2;
            Console.WriteLine($"Cantidad de sumas de sumador 2: {sumador2.Cantidad}"); // Cantidad de sumas: 1

            // Sobrecarga del operador |
            bool igualCantidadSumas = sumador1 | sumador2;
            Console.WriteLine($"¿Ambos sumadores tienen igual cantidad de sumas? {igualCantidadSumas}"); // ¿Ambos sumadores tienen igual cantidad de sumas? False

            Console.ReadKey();
        }
    }
}

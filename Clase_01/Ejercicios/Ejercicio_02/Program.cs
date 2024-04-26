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
            /* Ingresar un número y mostrar el cuadrado y el cubo 
             * del mismo. Se debe validar que el número sea mayor q
             * ue cero, caso contrario, mostrar el mensaje: 
             * "ERROR. ¡Reingresar número!".
             * */

            Console.Title = "Ejercicio Nro 02";

            bool esNumeroValido = false;
            int numeroIngresado;

            do
            {
                Console.Write("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > 0)
                {
                    esNumeroValido = true;
                }
                else
                {
                    Console.WriteLine("ERROR!\n¡Reingresar número!\n");
                }

            } while (!esNumeroValido);

            double cuadrado = Math.Pow(numeroIngresado, 2);
            double cubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine($"El cuadrado de {numeroIngresado} es: {cuadrado}");
            Console.WriteLine($"El cubo de {numeroIngresado} es: {cubo}");
            Console.ReadKey();
        }
    }
}

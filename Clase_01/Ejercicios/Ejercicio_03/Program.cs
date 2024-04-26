using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Mostrar por pantalla todos los números primos que haya hasta 
             * el número que ingrese el usuario por consola. Validar que 
             * el dato ingresado por el usuario sea un número. Volver a pedir 
             * el dato hasta que sea válido o el usuario ingrese "salir". 
             * Si ingresa "salir", cierra la consola.
             * Al finalizar, preguntar al usuario si desea volver 
             * a operar. Si la respuesta es afirmativa, iterar. 
             * De lo contrario, cerrar la consola.
             * */

            Console.Title = "Ejercicio Nro 03";

            bool operar = true;

            do
            {
                Console.WriteLine("Ingrese un número entero positivo o escriba 'salir' para salir:");
                string input = Console.ReadLine();

                if (input.ToLower() == "salir")
                {
                    Console.WriteLine("¡Hasta luego!");
                    Console.ReadKey();
                    return;
                }

                int number;

                /* Esto significa que intenta convertir el valor de input a un número entero (int) 
                 * y lo asigna a la variable number. Si TryParse devuelve false, significa que la 
                 * conversión falló, lo cual podría suceder si el usuario ingresa algo que 
                 * no es un número. Entonces, el operador ! lo convierte en true, 
                 * indicando que la conversión falló.
                 */
                if (!int.TryParse(input, out number) || number <= 1)
                {
                    Console.WriteLine("Por favor, ingresa un número entero positivo mayor que 1 o escribe 'salir' para salir.");
                    continue;
                }

                Console.WriteLine("Los números primos hasta " + number + " son:");

                for (int i = 2; i <= number; i++)
                {
                    bool esPrimo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                        Console.Write(i + " ");
                }
                Console.WriteLine();

                Console.WriteLine("¿Quieres hacer otra operación? (Sí/No)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "sí" && respuesta.ToLower() != "si")
                    operar = false;

            } while (operar);

            Console.ReadKey();
        }
    }
}

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
            /* Escribir un programa que imprima por consola un triángulo como el siguiente:
                *
                ***
                *****
                *******
                *********
             * El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. */

            Console.Title = "Ejercicio Nro 08";

            Console.Write("Ingrese el tamaño de la piramide: ");
            int tamanio;
            int i, j, z;

            if (int.TryParse(Console.ReadLine(), out tamanio))
            {
                for (i = tamanio, z = 1; i > 0; i--, z += 2)
                {
                    for (j = 0; j < z; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }
    }
}

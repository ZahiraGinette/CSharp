using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Un centro numérico es un número que separa una lista de números enteros 
             * (comenzandoen 1) en dos grupos de números, cuyas sumas son iguales.
             * El primer centro numérico es el 6, el cual separa la lista (1 a 8) 
             * en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
             * El segundo centro numérico es el 35, el cual separa la lista (1 a 49) 
             * en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
             * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 
             * y el número que el usuario ingrese por consola. */

            Console.Title = "Ejercicio Nro 05";

            Console.WriteLine("Ingrese un número entero positivo:");
            string input = Console.ReadLine();

            int maximo;
            if (!int.TryParse(input, out maximo) || maximo <= 1)
            {
                Console.WriteLine("Por favor, ingresa un número entero positivo mayor que 1.");
                return;
            }

            Console.WriteLine("Los centros numéricos hasta " + maximo + " son:");

            for (int i = 6; i <= maximo; i++)
            {
                int sumaAntes = 0;
                int sumaDespues = 0;

                for (int j = 1; j < i; j++)
                {
                    if (sumaAntes == sumaDespues)
                    {
                        sumaAntes += j;
                    }
                    else
                    {
                        sumaDespues += j;
                    }
                }

                if (sumaAntes == sumaDespues)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}

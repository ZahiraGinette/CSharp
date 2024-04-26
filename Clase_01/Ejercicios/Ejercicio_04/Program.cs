using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Un número perfecto es un entero positivo, que es igual a la 
             * suma de todos los enteros positivos (excluido el mismo) que 
             * son divisores del número.
             * El primer número perfecto es 6, ya que los divisores 
             * de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
             * Escribir una aplicación que encuentre los 4 primeros números perfectos. */

            Console.Title = "Ejercicio Nro 04";

            Console.WriteLine("Los primeros 4 números perfectos son:");

            int numero = 2;
            int encontrados = 0;

            while (encontrados < 4)
            {
                int sumaDivisores = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }

                if (sumaDivisores == numero)
                {
                    Console.WriteLine(numero);
                    encontrados++;
                }

                numero++;
            }

            Console.ReadKey();
        }
    }
}

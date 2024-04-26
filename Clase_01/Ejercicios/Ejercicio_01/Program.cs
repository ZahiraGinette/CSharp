using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ingresar 5 números por consola, guardándolos en una variable escalar. 
             * Luego calcular ymostrar: el valor máximo, el valor mínimo y el promedio.*/

            Console.Title = "Ejercicio Nro 01";

            float acumulador = 0;
            int numero;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;

            Console.Write("\nIngrese un número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                minimo = numero;
                maximo = numero;
                acumulador = acumulador + numero;

                for (int i = 1; i < 5; i++)
                {
                    Console.Write("\nIngrese un número: ");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        else if (numero > maximo)
                        {
                            maximo = numero;
                        }

                        acumulador = acumulador + numero;
                    }
                }

                promedio = acumulador / 5;
            }

            Console.WriteLine("El valor máximo es: {0:#,###.00}", maximo);
            Console.WriteLine("El valor mínimo es: {0:#,###.00}", minimo);
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);

            Console.ReadLine();
        }
    }
}

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
            /* Realizar una clase llamada Validador que posea un método estático 
             * llamado Validar con la siguiente firma:
             * 
             *       bool Validar(int valor, int min, int max)
             *
             *  • valor: dato a validar.
             *  • min: mínimo valor incluido.
             *  • max: máximo valor incluido.
             *
             * Pedir al usuario que ingrese 10 números enteros. 
             * Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
             * Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo 
             * ingresado y el promedio. */

            Console.Title = "Ejercicio Nro 01";

            int numero;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Ingrese el {0} numero. Entre los rango -100 y 100: ", i);
                while (int.TryParse(Console.ReadLine(), out numero) == false || Validacion.Validar(numero, -100, 100) == false)
                {
                    Console.Write("ERROR. Debe ingresar un numero valido. Reingrese: ");
                }

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

            promedio = acumulador / 10;
            Console.WriteLine("El valor máximo es: {0:#,###.00}", maximo);
            Console.WriteLine("El valor mínimo es: {0:#,###.00}", minimo);
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);

            Console.ReadKey();
        }
    }
}

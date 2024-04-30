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
            int[] numeros = new int[20];
            Random rnd = new Random();

            // Cargar 20 números enteros distintos de cero de forma aleatoria
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(-100, 101); // Generar números entre -100 y 100
                while (numeros[i] == 0) // Asegurarse de que no sean cero
                {
                    numeros[i] = rnd.Next(-100, 101);
                }
            }

            // Mostrar el vector tal como fue ingresado
            Console.WriteLine("Vector tal como fue ingresado:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

            // Mostrar los positivos ordenados en forma decreciente
            Console.WriteLine("\nPositivos ordenados en forma decreciente:");
            Array.Sort(numeros, (x, y) => y.CompareTo(x)); // Ordenar en forma decreciente
            foreach (int num in numeros)
            {
                if (num > 0)
                {
                    Console.Write(num + " ");
                }
            }

            // Mostrar los negativos ordenados en forma creciente
            Console.WriteLine("\nNegativos ordenados en forma creciente:");
            Array.Sort(numeros); // Ordenar en forma creciente
            foreach (int num in numeros)
            {
                if (num < 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.ReadKey();
        }
    }
}

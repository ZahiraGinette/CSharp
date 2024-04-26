using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesMultidimensionales
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*** Matriz de dos dimensiones */

            // ES FIJO
            // INSTANCIAR E INICIALIZAR 
            int[,] array = new int[3, 2] { { 1, 2 }, { 3, 5 }, { 3, 8 } };
            int[,] matriz = new int[4, 4] { { 1, 2 ,3,5}, { 3, 5 ,5,6}, { 3, 8 ,64,43} , { 3, 8 ,4,3} };

            // ACCEDER A LOS ELEMENTOS POR INDICE
            int elemento = array[2, 1];
            Console.WriteLine(elemento);
             
            // Mostrar los elementos utilizando un bucle for
            Console.WriteLine("Mostrando los elementos del arreglo usando un bucle for:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Elemento en la posición [{0}, {1}]: {2}", i, j, array[i, j]);
                }
            }

            Console.ReadKey();

            int[,,] cuboDeColores = new int[3, 3, 3] 
            {
                { // Capa Roja
                    {255, 0, 0}, // Fila 1
                    {128, 0, 0}, // Fila 2
                    {64, 0, 0}   // Fila 3
                },
                { // Capa Verde
                    {0, 255, 0}, // Fila 1
                    {0, 128, 0}, // Fila 2
                    {0, 64, 0}   // Fila 3
                },
                { // Capa Azul
                    {0, 0, 255}, // Fila 1
                    {0, 0, 128}, // Fila 2
                    {0, 0, 64}   // Fila 3
                }
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Capa " + (i + 1) + ":");
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 3; columna++)
                    {
                        Console.Write("[" + cuboDeColores[i, fila, columna] + "] ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

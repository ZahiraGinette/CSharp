using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesEscalonada
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ES IRREGULAR
            // INICIALIZAR E INSTANCIAR
            // MATRIZ ESCALONADA ( JAGGEDARRAY )
            int[][] jaggedArray = new int[4][];

            // MATRIZ MULTIDIMENSIONAL
            int[,] array = new int[3, 2] { { 1, 2 }, { 3, 5 }, { 3, 8 } }; 

            jaggedArray[0] = new int[5] { 1, 2, 3, 6, 5 };
            jaggedArray[1] = new int[3] { 0,3,6};
            jaggedArray[2] = new int[2] { 11,55 };
            jaggedArray[3] = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
  
            Console.WriteLine(jaggedArray[1][1]);
            Console.WriteLine("\n");

            Console.WriteLine("Contenido del arreglo jaggedArray:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Elemento " + i + ": [");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    if (j < jaggedArray[i].Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }

            Console.ReadKey();
         
        }
     
    }
}

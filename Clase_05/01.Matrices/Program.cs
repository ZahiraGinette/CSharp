using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAR E INICIALIZAMOS
            int[] edadesUno = new int[5] { 20,45,33,87,2 };
            string[] nombresUno = new string[4] {"Pedro", "Ana","Carlos","Brenda" };
            double[] precios = new double[2] { 34.3, 65.3 };
   
            // Acceder a cierta posicion de la matriz
            Console.WriteLine("Acceder a cierta posicion de la matriz");
            Console.WriteLine(edadesUno);
            Console.WriteLine(nombresUno);
            Console.WriteLine("\n"); 


            // Modificar posicion de la matriz 
            Console.WriteLine("Modificar posicion de la matriz");
            Console.WriteLine(edadesUno[3]);
            edadesUno[3] = 20; 
            Console.WriteLine(edadesUno[3]);
            Console.WriteLine("\n");

            // Mostrar toda la matriz
            Console.WriteLine("Mostrar toda la matriz");
            Console.WriteLine(edadesUno + "\n");

            // Para mostrar una matriz o arreglo, se debe recorrer con un bucle

            for(int i = 0; i < edadesUno.Length; i++)
            {
                Console.WriteLine(edadesUno[i]);
            }

            Console.WriteLine("\n");

            foreach(string nombre in nombresUno)
            {
                Console.WriteLine(nombre);
            }
             
             
            
             
        }
    }
}

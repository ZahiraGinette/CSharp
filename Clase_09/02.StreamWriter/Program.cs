using System;
using System.IO; 

namespace StreamWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"MisNotas\Nota.txt");

            sw.Write("Hola mundo!");

            sw.WriteLine("Adios mundo cruel");

            sw.Close();
 
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"MisNotas\bitacora.txt"))
            {
                writer.Write("Palabra");
                writer.WriteLine("Otras Palabras");
                writer.WriteLine("Una línea"); 
            }

            // Ejemplo con otro constructor 
            System.IO.StreamWriter swDos = new System.IO.StreamWriter(@"MisNotas\Nota.txt", true);

            swDos.Write("Mi ultimo comentario");

            swDos.Close();

            Console.ReadKey();

        }
    }
}

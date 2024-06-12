using System; 

namespace StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ruta del archivo de texto // Modificar de ser necesario
            string filePath = @"MisNotas\Nota.txt";

            // Crear una instancia de StreamReader para leer el archivo de texto
            using (System.IO.StreamReader lectura = new System.IO.StreamReader(filePath))
            {
                // Leer un carácter del archivo
                int character = lectura.Read();
                Console.WriteLine($"Carácter leído: {(char)character}");
                Console.WriteLine($"Carácter leído: {character}"); 
            }

            Console.ReadKey();

            using (System.IO.StreamReader lectura = new System.IO.StreamReader(filePath))
            { 
                // Leer una línea del archivo
                string line = lectura.ReadLine();
                Console.WriteLine($"Línea leída: {line}"); 
            }

            Console.ReadKey();

            using (System.IO.StreamReader lectura = new System.IO.StreamReader(filePath))
            {
                // Leer línea por línea
                string line;
                while ((line = lectura.ReadLine()) != null)
                {
                    Console.WriteLine($"Linea: {line}");
                }

            }

            Console.ReadKey();

            using (System.IO.StreamReader lectura = new System.IO.StreamReader(filePath))
            {   
                // Leer el contenido completo del archivo
                string content = lectura.ReadToEnd();
                Console.WriteLine($"Linea: {content}");

            }

            Console.ReadKey();
        }
    }
}

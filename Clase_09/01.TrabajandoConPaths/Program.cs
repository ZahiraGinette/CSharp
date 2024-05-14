using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Trabajando_con_paths
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region DirectorySeparatorChar y PathSeparator
            // Retorna el caracter separador de directorios para el sistema operativo sobre el que se ejecuta la aplicación.
            char directorySeparator = Path.DirectorySeparatorChar;

            // Retorna el caracter que se usa para separar una lista de rutas en el sistema operativo sobre el que se ejecuta la aplicación. 
            char pathSeparator = Path.PathSeparator;

            Console.WriteLine("Carácter separador de directorios: " + directorySeparator);
            Console.WriteLine("Carácter separador de rutas: " + pathSeparator);
            Console.ReadKey();
            #endregion

            #region Combine
            string ruta1 = @"E:\Proyectos\Clases Net\Clase 09";
            string ruta2 = "Archivo.txt";
            //  string ruta3 = "E:\Proyectos\Clases Net\Clase 09"; -> El arroba nos permite escribir caracteres especiales \

            // Combine paths y verifica si la primera ruta ya tiene un separador al final
            string rutaCompleta = Path.Combine(ruta1, ruta2);

            Console.WriteLine("Ruta combinada: " + rutaCompleta);
            Console.ReadKey();
            #endregion

            #region Join
            // Join está disponible desde .NET 6

            //string ruta3 = @"C:\Carpeta1";
            //string ruta4 = "Subcarpeta";
            //string archivo = "Archivo.txt";

            //string rutaCompletaJoin = Path.Join(ruta1, ruta2, archivo);

            //Console.WriteLine("Ruta combinada: " + rutaCompletaJoin);

            //Console.ReadKey();
            #endregion

            #region GetCurrentDirectory
            //string currentDirectory = Directory.GetCurrentDirectory();

            //Console.WriteLine("Directorio actual: " + currentDirectory);
            //Console.ReadKey();

            #endregion

            #region Delete
            string directoryPath = @"E:\Proyectos\Clases Net\Clase 09\Tercera carpeta";

            if (Directory.Exists(directoryPath))
            {
                Directory.Delete(directoryPath);
                Console.WriteLine("Directorio eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }

            Console.ReadKey();

            #endregion

            #region Delete(path,boolean)
            string directoryPathDos = @"E:\Proyectos\Clases Net\Clase 09\Tercera carpeta";

            if (Directory.Exists(directoryPathDos))
            {
                Directory.Delete(directoryPathDos, true); // El segundo parámetro indica si se deben eliminar los subdirectorios y archivos
                Console.WriteLine("Directorio y contenido eliminados correctamente.");
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }
            Console.ReadKey();

            #endregion

            #region Exists

            string directoryPathTres = @"E:\Proyectos\Clases Net\Clase 09\Segunda carpeta";

            if (Directory.Exists(directoryPathTres))
            {
                Console.WriteLine("El directorio existe.");
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }
            Console.ReadKey();
            #endregion

            #region GetFiles

            string directoryPathCuatro = @"E:\Proyectos\Clases Net\Clase 09\Tercera carpeta";

            string[] files = Directory.GetFiles(directoryPathCuatro);

            Console.WriteLine("Archivos en el directorio:");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();
        }

        #endregion
    
    }
}

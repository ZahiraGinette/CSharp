using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depuracion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine($"Hola, {nombre}. Hoy es {fechaActual:d} a las {fechaActual:t}");
            Console.WriteLine($"Presione cualquier tecla para salir"); 
            Console.ReadKey();

        }
    }
}

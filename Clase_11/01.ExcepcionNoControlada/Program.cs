using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Excepcion_no_controlada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            // Accediendo a un indice fuera de los límites del array
            Console.WriteLine(numbers[3]);

            Console.WriteLine("Mensaje");

            Console.ReadKey();
        }
    }
}

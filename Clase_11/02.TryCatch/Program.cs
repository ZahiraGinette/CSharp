using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoExcepcion();
            Console.ReadKey();
        }

        public static void MetodoExcepcion()
        {
            try
            {
                Console.WriteLine("Escriba un número:");
                int i = int.Parse(Console.ReadLine());

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Se produjo un error y estoy en catch");
            }

            Console.WriteLine("Es un mensaje fuera del bloque");
        }
    }
}

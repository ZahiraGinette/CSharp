using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorConversionMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            SegundaClase segundaClase = new SegundaClase();

            Console.WriteLine(segundaClase - 5);

            Console.WriteLine((string)segundaClase);

            Console.WriteLine((int)segundaClase);

            Console.WriteLine((PrimeraClase)segundaClase);

            Console.ReadKey();
        }
    }
}

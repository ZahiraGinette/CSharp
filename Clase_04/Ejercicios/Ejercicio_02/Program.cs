using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";


            NumeroBinario numeroBinario = (NumeroBinario)"1001";
            NumeroDecimal numeroDecimal = (NumeroDecimal)9;

            Console.WriteLine($"El número binario es {numeroBinario.Numero}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");
            Console.WriteLine($"El número decimal es {numeroDecimal.Numero}, sumado con el binario da un total de {numeroBinario + numeroDecimal}");

            Console.ReadKey();

        }
    }
}

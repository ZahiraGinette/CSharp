using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desarrollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
             * El método ConvertirDecimalABinario que convierte un número entero del
             * sistema decimal al sistema binario.
             * 
             *      public string ConvertirDecimalABinario(int numeroEntero) {}
             *  
             *  El método ConvertirBinarioADecimal que convierte un número entero del 
             *  sistema binario al sistema decimal.
             *  
             *      public int ConvertirBinarioADecimal(int numeroEntero) {}*/

            Console.Title = "Ejercicio Nro 03";

            int numeroDecimal = 42;
            string binario = Conversor.ConvertirDecimalABinario(numeroDecimal);
            Console.WriteLine($"El número {numeroDecimal} en binario es: {binario}");

            // Convertir binario a decimal
            int numeroBinario = 101010;
            int decimalResultante = Conversor.ConvertirBinarioADecimal(numeroBinario);
            Console.WriteLine($"El número binario {numeroBinario} en decimal es: {decimalResultante}");

            Console.ReadLine();
        }
    }
}

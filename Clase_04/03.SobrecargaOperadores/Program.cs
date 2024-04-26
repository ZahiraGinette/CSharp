using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculadora

            Calculadora calc = new Calculadora(10);

            double suma = calc.ObtenerResultado() + 30;

            Console.WriteLine("Resultado inicial: " + calc.ObtenerResultado());
            Console.WriteLine("Suma: " + (calc + 5));
            Console.WriteLine("Resta: " + (calc - 3));

            Console.WriteLine("Multiplicación uno: " + (calc.ObtenerResultado() * 2));

            Console.WriteLine("Multiplicación dos: " + (calc * 2));

            Console.WriteLine("División: " + (calc / 4));


            calc.Limpiar();
            Console.WriteLine("Resultado después de limpiar: " + calc.ObtenerResultado());
            #endregion
        }
    }
}

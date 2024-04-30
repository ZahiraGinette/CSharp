using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            Euro billeteEuro = 1;
            Peso billetePeso = (Peso)billeteEuro;
            Dolar billeteDolar = 100;

            Console.WriteLine("${0:#,###.00}",billetePeso.Cantidad);
            billetePeso = (Peso)billeteDolar;
            Console.WriteLine("Cantidad de Dolares convertidos a Pesos: ${0:#,###.00}", billetePeso.Cantidad);

            Console.ReadKey();
        }
    }
}

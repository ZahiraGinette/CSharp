using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convertir de Metros a Pies (Conversion implicita)
            DistanciaMetros metros = new DistanciaMetros(10);
            DistanciaPies pies = metros; // Utiliza el operador de conversión implícito
            Console.WriteLine($"Distancia en Pies: {pies.Pies()}");

            DistanciaMetros ejemploNuevo = new DistanciaMetros(5);
            NuevaClase nueva = ejemploNuevo;
            Console.WriteLine($"Distancia en Pies: {nueva.Mostrar()}");


            Console.ReadKey();

            // Convertir de Pies a Metros (Conversion explicita)
            DistanciaPies distanciaPies = new DistanciaPies(32.8084);
            DistanciaMetros metros2 = (DistanciaMetros)distanciaPies; // Utiliza el operador de conversión explícito
            Console.WriteLine($"Distancia en Metros: {metros2.Metros()}");

            DistanciaPies segundaDistanciaPies = new DistanciaPies(39.4);
            NuevaClase nuevaDos = (NuevaClase)segundaDistanciaPies;
            Console.WriteLine($"Distancia en Metros: {nuevaDos.Mostrar()}");

            Console.ReadKey();
        }
    }
}

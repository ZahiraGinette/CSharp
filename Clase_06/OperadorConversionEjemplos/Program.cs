using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorConversion_ejemplos
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Conversión implícita de Metro a double 
            Metro metro = new Metro(150);
            double longitudEnMetros = metro; // Conversión implícita
            Console.WriteLine($"Longitud en metros: {longitudEnMetros}");

            // Conversión implícita de Metro a Kilometro
            Metro metroDos = new Metro(1000);
            Kilometro kilometro = metroDos; // Conversión implícita
            Console.WriteLine($"Longitud en kilómetros: {kilometro.Longitud}");

            // Conversión explícita de Kilometro a Metro
            Kilometro kilometroUno = new Kilometro(82);
            Metro metroTres = (Metro)kilometroUno; // Conversión explícita
            Console.WriteLine($"Longitud en metros desde kilómetros: {metroTres.Longitud}");

            // Conversión explícita de Kilometro a Metro
            Kilometro kilometroDos = new Kilometro(34);
            double longitudEnKilometros = kilometroDos; // Conversión implícita
            Console.WriteLine($"Longitud en kilómetros: {longitudEnKilometros}");

            Console.ReadKey();
        }
    }
}

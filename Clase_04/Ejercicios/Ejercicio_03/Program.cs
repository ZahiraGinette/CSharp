using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            // Crear instancias de temperaturas en diferentes escalas
            Fahrenheit f1 = new Fahrenheit(32);
            Kelvin k1 = new Kelvin(273.15);
            Celsius c1 = new Celsius(0);

            // Realizar conversiones entre las escalas de temperatura
            Kelvin kFromF = (Kelvin)f1;
            Celsius cFromF = (Celsius)f1;

            Fahrenheit fFromK = (Fahrenheit)k1;
            Celsius cFromK = (Celsius)k1;

            Fahrenheit fFromC = (Fahrenheit)c1;
            Kelvin kFromC = (Kelvin)c1;

            // Realizar operaciones aritméticas
            Fahrenheit sumFK = f1 + k1;
            Fahrenheit sumFC = f1 + c1;
            Fahrenheit subFK = f1 - k1;
            Fahrenheit subFC = f1 - c1;

            // Incrementar y decrementar temperaturas
            Fahrenheit incF = f1++;
            Fahrenheit decF = f1--;

            // Comprobar igualdad y desigualdad entre temperaturas
            bool isEqualFK = f1 == k1;
            bool isNotEqualFC = f1 != c1;

            // Mostrar resultados
            Console.WriteLine("Conversiones:");
            Console.WriteLine($"32°F en Kelvin: {kFromF.Valor} K");
            Console.WriteLine($"32°F en Celsius: {cFromF.Valor} °C");
            Console.WriteLine($"273.15 K en Fahrenheit: {fFromK.Valor} °F");
            Console.WriteLine($"273.15 K en Celsius: {cFromK.Valor} °C");
            Console.WriteLine($"0°C en Fahrenheit: {fFromC.Valor} °F");
            Console.WriteLine($"0°C en Kelvin: {kFromC.Valor} K");

            Console.WriteLine("\nOperaciones aritméticas:");
            Console.WriteLine($"32°F + 273.15 K = {sumFK.Valor} °F");
            Console.WriteLine($"32°F + 0°C = {sumFC.Valor} °F");
            Console.WriteLine($"32°F - 273.15 K = {subFK.Valor} °F");
            Console.WriteLine($"32°F - 0°C = {subFC.Valor} °F");

            Console.WriteLine("\nIncremento y decremento:");
            Console.WriteLine($"Incremento de 32°F: {incF.Valor} °F");
            Console.WriteLine($"Decremento de 33°F: {decF.Valor} °F");

            Console.WriteLine("\nComprobación de igualdad y desigualdad:");
            Console.WriteLine($"¿32°F es igual a 273.15 K?: {isEqualFK}");
            Console.WriteLine($"¿32°F no es igual a 0°C?: {isNotEqualFC}");

            Console.ReadKey();
        }
    }
}

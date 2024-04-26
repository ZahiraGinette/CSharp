using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            // Crear bolígrafos
            Boligrafo boligrafoAzul = new Boligrafo(10, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(3, ConsoleColor.Red);

            // Mostrar información inicial
            Console.WriteLine("Bolígrafo Azul:");
            Console.WriteLine($"Color: {boligrafoAzul.GetColor()}");
            Console.WriteLine($"Tinta restante: {boligrafoAzul.GetTinta()}");

            Console.WriteLine("\nBolígrafo Rojo:");
            Console.WriteLine($"Color: {boligrafoRojo.GetColor()}");
            Console.WriteLine($"Tinta restante: {boligrafoRojo.GetTinta()}");

            // Utilizar métodos Recargar y Pintar
            string dibujo;
            boligrafoAzul.Pintar(2, out dibujo);
            Console.ForegroundColor = boligrafoAzul.GetColor();
            Console.WriteLine($"\nDespués de pintar con el bolígrafo Azul:");
            Console.WriteLine($"Tinta restante: {boligrafoAzul.GetTinta()}");
            Console.WriteLine($"Dibujo: {dibujo}");
            boligrafoAzul.Recargar();
            Console.WriteLine($"\nDespués de recargar el bolígrafo Azul:");
            Console.WriteLine($"Tinta restante: {boligrafoAzul.GetTinta()}");
            Console.ResetColor();

            // Intentar pintar más de lo que tiene el bolígrafo Rojo
            short gasto = 10;
            bool pudoPintar = boligrafoRojo.Pintar(gasto, out dibujo);
            if (pudoPintar)
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
                Console.WriteLine($"\nPintando con el bolígrafo Rojo (intentando gastar {gasto} unidades de tinta):");
                Console.WriteLine($"Tinta restante: {boligrafoRojo.GetTinta()}");
                Console.WriteLine($"Dibujo: {dibujo}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
                Console.WriteLine($"\nNo se pudo pintar con el bolígrafo Rojo. No hay suficiente tinta (intentando gastar {gasto} unidades de tinta):");
                Console.WriteLine($"Dibujo: {dibujo}");
            }

            Console.ReadLine();
        }
    }
}

using Geometria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            // Crear puntos para los vértices del rectángulo
            Punto vertice1 = new Punto(1, 1);
            Punto vertice3 = new Punto(5, 4);

            // Crear rectángulo
            Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);

            Console.WriteLine("Datos del Rectángulo:");
            Console.WriteLine($"Área: {rectangulo.Area()}");
            Console.WriteLine($"Perímetro: {rectangulo.Perimetro()}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicios_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            Automovil auto = new Automovil(4, 4, Colores.Rojo, 5, 4);
            Ciclomotor ciclomotor = new Ciclomotor(2, 0, Colores.Azul, 250);
            Furgon furgon = new Furgon(6, 2, Colores.Gris, 6, 10000);

            Console.WriteLine("Automovil:");
            Console.WriteLine($"Cantidad de ruedas: {auto.CantidadRuedas}");
            Console.WriteLine($"Cantidad de puertas: {auto.CantidadPuertas}");
            Console.WriteLine($"Color: {auto.Color}");
            Console.WriteLine($"Cantidad de marchas: {auto.CantidadMarchas}");
            Console.WriteLine($"Cantidad de pasajeros: {auto.CantidadPasajeros}");
            Console.WriteLine("========================================================");
            Console.WriteLine("\nMoto:");
            Console.WriteLine($"Cantidad de ruedas: {ciclomotor.CantidadRuedas}");
            Console.WriteLine($"Cantidad de puertas: {ciclomotor.CantidadPuertas}");
            Console.WriteLine($"Color: {ciclomotor.Color}");
            Console.WriteLine($"Cilindrada: {ciclomotor.Cilindrada}");
            Console.WriteLine("========================================================");
            Console.WriteLine("\nCamion:");
            Console.WriteLine($"Cantidad de ruedas: {furgon.CantidadRuedas}");
            Console.WriteLine($"Cantidad de puertas: {furgon.CantidadPuertas}");
            Console.WriteLine($"Color: {furgon.Color}");
            Console.WriteLine($"Cantidad de marchas: {furgon.CantidadMarchas}");
            Console.WriteLine($"Peso de carga: {furgon.PesoCarga} kg");

            Console.ReadLine();
        }
    }
}

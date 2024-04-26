using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            // Instanciar clientes y mascotas
            Cliente cliente1 = new Cliente("Juan", "Pérez", "Calle 123", 123456789)
            {
                Mascota = new Mascota("Perro", "Firulais", new DateTime(2019, 5, 10))
            };

            Cliente cliente2 = new Cliente("María", "García", "Avenida 456", 987654321)
            {
                Mascota = new Mascota("Gato", "Michi", new DateTime(2020, 8, 20)) { Vacuna = "Triple Felina" }
            };

            Cliente cliente3 = new Cliente("Pedro", "López", "Plaza 789", 567891234)
            {
                Mascota = new Mascota("Gato", "Luna", new DateTime(2018, 10, 15)) { Vacuna = "Rabia" }
            };

            // Mostrar información de los clientes y sus mascotas por consola
            Console.WriteLine("Cliente 1:");
            Console.WriteLine(cliente1);
            Console.WriteLine();

            Console.WriteLine("Cliente 2:");
            Console.WriteLine(cliente2);
            Console.WriteLine();

            Console.WriteLine("Cliente 3:");
            Console.WriteLine(cliente3);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

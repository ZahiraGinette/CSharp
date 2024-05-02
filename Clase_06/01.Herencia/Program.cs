using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Herencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto Perro
            Perro miPerro = new Perro("Fido", 5, "Labrador");

            // Mostrar información del perro
            Console.WriteLine("Información del perro:");
            Console.WriteLine($"Nombre: {miPerro.Nombre}");
            Console.WriteLine($"Edad: {miPerro.Edad}");
            Console.WriteLine($"Raza: {miPerro.Raza}");

            // Creamos objeto gato
            Gato miGato = new Gato("Whiskers", 3, true);

            // Mostrar información del gato
            Console.WriteLine("\nInformación del gato:");
            Console.WriteLine($"Nombre: {miGato.Nombre}");
            Console.WriteLine($"Edad: {miGato.Edad}");
            Console.WriteLine($"¿Es peludo?: {miGato.EsPeludo}");
             

            // Creamos un objeto animal
            Animal conejo = new Animal("Canelita", 2);
            Console.WriteLine("\nInformación del conejo:");
            Console.WriteLine($"Nombre: {conejo.Nombre}");
            Console.WriteLine($"Edad: {conejo.Edad}");

            Console.ReadKey();
        }
    }
}

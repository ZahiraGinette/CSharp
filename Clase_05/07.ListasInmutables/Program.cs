using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasInmutables
{
    public class Program
    {
            static void Main(string[] args)
            {
                var ciclistas = ImmutableArray.Create(
                new Ciclista("Juan", 25),
                new Ciclista("María", 30),
                new Ciclista("Pedro", 28)
                );
             
            Console.WriteLine("Lista de ciclistas:");
            foreach (var ciclista in ciclistas)
            {
                Console.WriteLine(ciclista.Mostrar());
            }

            Console.WriteLine("\n");

            // Intentar modificar la lista inmutable (no se permitirá)
            ciclistas.Add(new Ciclista("Luis", 32)); // Esto generaría un error en tiempo de compilacion


            Console.WriteLine("Lista de ciclistas:");
            foreach (var ciclista in ciclistas)
            {
                Console.WriteLine(ciclista.Mostrar());
            }


            // crear una nueva lista inmutable con un ciclista adicional
            var nuevaLista = ciclistas.Add(new Ciclista("Luis", 32));


            // Mostrar la nueva lista
            Console.WriteLine("\nNueva lista de ciclistas:");
            foreach (var ciclista in nuevaLista)
            {
                Console.WriteLine(ciclista.Mostrar());
            }

            Console.ReadKey();
        }
    }
}

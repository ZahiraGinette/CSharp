using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Herencia_no_polimorfica
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Forma que me mostrara cada animal */
            Animal animalUno = new Animal();
            Perro perroUno = new Perro();
            Gato gatoUno = new Gato();

            Console.WriteLine($"Animal: {animalUno.EmitirSonido()}");
            Console.WriteLine($"Perro: {perroUno.EmitirSonido()}");
            Console.WriteLine($"Gato: {gatoUno.EmitirSonido()}");

            Console.WriteLine($"------------------");
             
            /* Solo me mostrara lo que devuelve animal */
            Animal animal = new Animal();
            Animal perro = new Perro();
            Animal gato = new Gato();

            Console.WriteLine($"Animal: {animal.EmitirSonido()}");
            Console.WriteLine($"Perro: {perro.EmitirSonido()}");
            Console.WriteLine($"Gato: {gato.EmitirSonido()}");

            Console.ReadKey();
        }
    }
}

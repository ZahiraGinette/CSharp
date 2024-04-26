using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota perro = new Mascota("Milanesa",3,"Pug","Perro");
            Console.WriteLine(perro.Saludar("Hola"));

            Mascota gato = new Mascota("Bolita de algodon", 1, "Siames", "Gato");
            Console.WriteLine(gato.Saludar("Hola"));

            Mascota conejo = new Mascota("Jack", 10, "Conejo", "Conejo");
            Console.WriteLine(conejo.Saludar(" ... "));
           


            Console.ReadKey();
        }
    }
}

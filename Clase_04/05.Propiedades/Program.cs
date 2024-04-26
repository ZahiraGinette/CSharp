using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", 30, "Perez");

            persona1.MostrarPersona();

            persona1.Nombre = "Carlos";

            persona1.MostrarPersona();

            persona1.Nombre = "Veronica";

            persona1.MostrarPersona();

            Console.WriteLine(persona1.Nombre);

            Console.ReadKey();
        }
    }
}

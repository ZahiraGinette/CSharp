using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Program
    {
        static void Main(string[] args)
        {


            // Constructor explicito

          //  Persona personaDos = new Persona("Veronica", "Bustos", 28);

          //  Persona persona = new Persona("Jose", "Perez", 37);
 
            // Si hay una declaracion explicita de constructor, se anula el por defecto
            //  Persona personaDos = new Persona();


            // Constructor por defecto
           /* Vehiculo vehiculo = new Vehiculo();

            Ovni ovni = new Ovni();*/


            Mascota.Saludar();

            Console.ReadKey();
        }
    }
}

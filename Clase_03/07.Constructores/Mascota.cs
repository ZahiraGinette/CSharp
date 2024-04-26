using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Mascota
    {
        private static string especie;
        private static string nombre;

        // Constructor estático para inicializar los datos de la mascota
        static Mascota()
        {
            especie = "Gato";
            nombre = "Nube";
        }
 

        // Metodo estático 
        public static void Saludar()
        {
            Console.WriteLine($"La mascota se llama {nombre}, y la especie es {especie}");
        }
    }
}

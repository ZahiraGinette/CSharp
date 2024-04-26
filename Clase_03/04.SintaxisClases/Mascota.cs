using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxisClases
{
    // Modificador - Palabra reservada Class - Identificador
    public class Mascota
    {
        // Atributos 
        // Modificador - Tipo - Identificador 
        public string nombre;
        public int edad;
        public string raza;
        public string especie;
        public bool hambre;

        // Metodos
        public string Saludar()
        {
            return $"Hola mi nombre es {this.nombre} soy un {this.especie} y tengo {this.edad} años";
        }

        public static void Alimentar(Mascota mascota)
        {
            if(!mascota.hambre)
            {
                mascota.hambre = true;
            }
        }



    }
}

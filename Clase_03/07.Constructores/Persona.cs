using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        // Constructor de instancia
        public Persona(string nombre, string apellido, int edad)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string CambiarNombre(string nombre)
        {
            this.nombre = nombre;
            return this.nombre;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Modificador_protected
{
    public class Persona
    {
        protected string nombre;
        protected long dni;
       
        public Persona(string nombre)
        {
            this.nombre = nombre; 
        }

        public Persona(long dni)
        {
            this.dni = dni;
        }

        protected void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {this.nombre}"); 
        }
    }
}

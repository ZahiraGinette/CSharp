using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Constructores
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

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {this.nombre}"); 
        }
    }
}

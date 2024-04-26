using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Persona
    {
        private string _nombre;
        private int _edad;
        private DateTime _fechaNacimiento;
        private int _numeroDocumento;

        public Persona()
        { }

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public Persona(string nombre, int edad, DateTime fechaNacimiento) : this(nombre, edad)  
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public Persona(string nombre, int edad, DateTime fechaNacimiento, int numeroDocumento) : this(nombre, edad, fechaNacimiento)
        {
            _numeroDocumento = numeroDocumento;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesGenericas
{
    public class Persona
    {
        private string _nombre;
        private int _edad;

        public Persona(string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Saludar()
        {
            return "¡Hola! Mi nombre es " + _nombre + " y tengo " + _edad + " años.";
        }
    }
}

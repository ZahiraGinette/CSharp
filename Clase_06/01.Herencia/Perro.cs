using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Herencia
{
    public class Perro : Animal
    {
        // Atributos
        private string _raza;

        // Propiedad
        public string Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }

        // Constructor
        public Perro(string nombre, int edad, string raza) : base(nombre, edad)
        {
            _raza = raza;
        }
         
    }
}

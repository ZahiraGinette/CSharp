using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Herencia
{
    public class Gato : Animal
    {
        private bool _esPeludo;

        public bool EsPeludo { get; set; }

        // Constructor
        public Gato(string nombre, int edad, bool esPeludo) : base(nombre, edad)
        {
            this._esPeludo = esPeludo;
        }
    }
}

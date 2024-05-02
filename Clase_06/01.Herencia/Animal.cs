using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Herencia
{
    public class Animal
    {
        // Atributos
        private string _nombre;
        private int _edad;

        // Constructor
        public Animal()
        {

        }

        public Animal(string nombre)
        {
            _nombre = nombre;
        }

        public Animal(string nombre, int edad) : this(nombre) 
        { 
            _edad = edad;
        }
         
        // Propiedades
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
         
    }
}

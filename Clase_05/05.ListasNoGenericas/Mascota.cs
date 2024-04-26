using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasNoGenericas
{
    public class Mascota
    {
        // Atributos
        private string _nombre;
        private int _edad;
        private string _especie;

        // Constructor
        public Mascota(string nombre, int edad, string especie)
        {
            _nombre = nombre;
            _edad = edad;
            _especie = especie;
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

        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

    
        public void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + _nombre);
            Console.WriteLine("Edad: " + _edad + " años");
            Console.WriteLine("Especie: " + _especie);
        }
    }
}

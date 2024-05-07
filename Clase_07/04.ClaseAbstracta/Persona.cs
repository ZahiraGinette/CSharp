using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ClaseAbastractca
{
    // MODICADOR - ABSTRACT - CLASS - NOMBRECLASE
    public abstract class Persona
    {
        protected string _nombre;
        protected int _edad;

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad; 
        }

        // METODOS - PROPIEDADES - INDICES -> Abstract

        public string Nombre
        {
            get { return _nombre; }
            set { this._nombre = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { this._edad = value; }
        } 
         
        // Metodo abstracto que debe ser implementado por las clases derivadas
        public abstract void Saludar();

        public override bool Equals(object obj)
        {
            return obj == this;
        }

        public virtual string Mensaje()
        {
            return "MENSAJE";
        }
    }
}

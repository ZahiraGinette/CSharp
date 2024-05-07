using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ClaseAbastractca
{
    public class Profesor : Persona
    {
        private string _especialidad;

        public Profesor (string nombre, int edad, string especialidad) : base(nombre, edad)
        {
            this._especialidad = especialidad;
        }

        public string Especialidad
        {
            get { return this._especialidad; }
            set { this._especialidad = value; }
        }

        // Implementación del método abstracto Saludar, se utiliza la palabra OVERRIDE
        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy el profesor {Nombre}, tengo {Edad} años y mi especialidad es {Especialidad}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ClaseAbastractca
{
    public class Estudiante : Persona
    {
        private string _curso;

        public Estudiante(string nombre, int edad,string curso) : base(nombre, edad)
        {
            this._curso = curso;
        }

        public string Curso 
        {
            get { return this._curso; }
            set { this._curso = value; }
        }

        // Implementación del método abstracto Saludar, se utiliza la palabra OVERRIDE
        public override void Saludar()
        {   
            Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y estoy en el curso {Curso}.");
        }
    }
}

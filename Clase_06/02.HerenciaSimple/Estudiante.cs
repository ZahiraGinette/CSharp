using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Herencia_simple
{
    public class Estudiante : Persona
    {
        private string _grado; 

        public string Grado
        {
            get
            {
                return _grado;
            }
            set
            {
                _grado = value;
            }
        }

        // Constructor
        public Estudiante(string nombre, int edad, string genero, string grado) : base(nombre, edad, genero)
        {
            _grado = grado;
        } 

        // Metodo para estudiar
        public void Estudiar()
        { 
            MostrarInformacion();
            Console.WriteLine($"{Nombre} está estudiando para el grado de {Grado}."); 
        }


    }
}

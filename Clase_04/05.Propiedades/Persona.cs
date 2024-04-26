using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string apellido;

        public Persona(string nombre, int edad, string apellido)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get // Get es obtener
            {
                return this.nombre + " este es un nombre";
            }
            set // Set es asignar
            {
                this.nombre = value; // value representa el valor que se le asignara 
            }
        }

        public int Edad { get; set; }

        public string Apellido
        {
            get // 
            {
                return "Esto es un apellido";
            }
        }


        public void MostrarPersona()
        {
            Console.WriteLine($"El nombre de la persona es {this.nombre} y su edad es {this.edad}");
        }
    }
}

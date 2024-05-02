using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Herencia_simple
{
    public class Persona
    {
        protected int id;

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
         
        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }
         
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Género: {Genero}");
        }
    }
}

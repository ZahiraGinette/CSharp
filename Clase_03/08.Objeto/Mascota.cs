using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{ 
    public class Mascota
    {
        private string nombre;
        private  int edad;
        private string raza;
        private string especie;
        private bool hambre;

        public Mascota(string nombre, int edad, string raza, string especie)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.raza = raza;
            this.especie = especie; 
        }

 
        // Metodos
        public string Saludar(string mensajeExtra)
        {
            return $"Hola mi nombre es {this.nombre} soy un {this.especie} y tengo {this.edad} año/s. El animal quiere decirte {mensajeExtra}";
        }
         
    }
}
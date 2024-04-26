using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasInmutables
{
    public class Ciclista
    {
        private string _nombre;
        private int _edad;

        public string Nombre { get; }
        public int Edad { get; }

        public Ciclista(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public string Mostrar()
        {
            return $"Nombre: {_nombre}, Edad: {_edad}";
        }
    }
}

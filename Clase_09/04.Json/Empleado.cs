using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Json
{
    public class Empleado
    {
        private string _nombre; 
        private int _edad; 
        private string _apellido;
        
        // Datos para tener atajos, usar prop + doble tab o sino propfull + doble tab 
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        private string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }


        public Empleado() { }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad; 
        }
        

        public Empleado(string nombre, int edad, string apellido) : this(nombre,edad)
        { 
            Apellido = apellido;
        }


    }
}

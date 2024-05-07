using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sobreescritura_equivalencias
{
    public class Persona
    {
        private string _nombre;
        private string _dni;

        public Persona(string nombre, string dni)
        {
            _nombre = nombre;
            _dni = dni;
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            // El referenceEquals determina si dos instancias son la misma
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            {
                return false;
            } 
            return p1._nombre == p2._nombre && p1._dni == p2._dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
             return !(p1 == p2); 
        }

        // El metodo Equals es para comparar, compara si un objeto de tipo Persona es igual a otro objeto
        // En este caso compara si dos objetos de tipo PERSONA poseen el mismo documento y dni
        public override bool Equals(object obj)
        {
            Persona p = obj as Persona;
            return p != null && this == p;
        }

        // Combina los valores los valores hash de sus elementos de manera eficiente para producir un valor hash unico
        // para la instancia de 'Persona'
        public override int GetHashCode()
        {
            return (_nombre, _dni).GetHashCode();
        }

        // Cadena de objeto
        public override string ToString()
        {
            return $"{_nombre} , {_dni}";
        } 
    }
}

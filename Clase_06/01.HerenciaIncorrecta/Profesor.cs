using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_a.Herencia_incorrecta
{
    public class Profesor
    {
        // Atributos privados
        private string apellido;
        private string catedra;
        private long dni;
        private string nombre;

        // Constructor
        public Profesor(string nombre, string apellido, long dni, string catedra)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.catedra = catedra;
        }

        // Metodo para corregir
        public string Corregir()
        {
            return $"{nombre} {apellido} está corrigiendo exámenes de la cátedra de {catedra}.";
        }
    }
}

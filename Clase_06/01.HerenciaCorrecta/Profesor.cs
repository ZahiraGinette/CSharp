using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_b.Herencia_correcta
{
    public class Profesor : Persona
    {
        // Atributo único de Profesor
        private string catedra;

        // Constructor
        public Profesor(string nombre, string apellido, long dni, string catedra) : base(nombre, apellido, dni) // Llamada al constructor de Persona
        {
            this.catedra = catedra;
        }

        // Método para corregir
        public string Corregir()
        {
            return $"{nombre} {apellido} está corrigiendo exámenes de la cátedra de {catedra}.";
        }
    }
}

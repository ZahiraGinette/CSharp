using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_b.Herencia_correcta
{
    public class Estudiante : Persona
    { 
        private string legajo;
        private List<string> materias;

        // Constructor
        public Estudiante(string nombre, string apellido, long dni, string legajo, List<string> materias) : base(nombre, apellido, dni) // Llamada al constructor de Persona
        {
            this.legajo = legajo;
            this.materias = materias;
        }

        // Metodo para estudiar
        public string Estudiar()
        {
            StringBuilder stringBuilder = new StringBuilder($"\n{nombre} {apellido} está estudiando las materias:\n");
            foreach (string materia in materias)
            {
                stringBuilder.AppendLine(materia);
            }
            return stringBuilder.ToString();
        }
    }
}

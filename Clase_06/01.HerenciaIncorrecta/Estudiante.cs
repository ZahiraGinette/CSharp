using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_a.Herencia_incorrecta
{
    public class Estudiante
    {  
        private string apellido;
        private long dni;
        private string legajo;
        private List<string> materias;
        private string nombre;

        // Constructor
        public Estudiante(string nombre, string apellido, long dni, string legajo, List<string> materias)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.legajo = legajo;
            this.materias = materias;
        }

        // Método para estudiar
        public string Estudiar()
        {
            StringBuilder stringBuilder = new StringBuilder($"\n{nombre} {apellido} está estudiando las materias:\n");
            foreach(string materia in materias)
            {
                stringBuilder.AppendLine(materia);
            }
            return stringBuilder.ToString();
        }

    }
}

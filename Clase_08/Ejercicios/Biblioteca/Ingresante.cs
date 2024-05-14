using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ingresante : Persona
    {
        #region Atributos
        private List<Curso> cursos;
        #endregion

        #region Propiedades
        public List<Curso> Cursos { get { return cursos; }  set { cursos = value; } }
        #endregion

        #region Constructores

        public Ingresante(string nombre, int edad, EGenero genero, string direccion, string pais, List<Curso> cursos)
            : base(nombre, edad, genero, direccion, pais)
        {
            this.cursos = cursos;
        }
        #endregion

        #region Métodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dirección: {Direccion}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Género: {Genero}");
            sb.AppendLine($"País: {Pais}");
            sb.AppendLine($"Curso/s: ");
            cursos.ForEach(x => sb.AppendLine(x.Nombre));

            return sb.ToString();
        }
        #endregion
    }
}

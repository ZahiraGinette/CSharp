using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Curso
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        #endregion

        #region Constructores
        public Curso(string nombre) 
        { 
            this.nombre = nombre;
        }
        #endregion

        #region Polimorfismo
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Curso otroCurso = (Curso)obj;
            return Nombre == otroCurso.Nombre;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
        #endregion
    }
}

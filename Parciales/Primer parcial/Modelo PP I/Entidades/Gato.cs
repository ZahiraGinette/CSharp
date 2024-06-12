using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa a un gato, una subclase de Mascota.
    /// </summary>
    public class Gato : Mascota
    {
        #region Constructores
        /// <summary>
        /// Constructor de la clase Gato.
        /// </summary>
        /// <param name="nombre">Nombre del gato.</param>
        /// <param name="raza">Raza del gato.</param>
        public Gato(string nombre, string raza) 
            : base(nombre, raza)
        {

        }
        #endregion

        #region Métodos
        /// <summary>
        /// Genera una ficha del gato con sus datos.
        /// </summary>
        /// <returns>Ficha del gato.</returns>
        protected override string Ficha()
        {
            return DatosCompletos();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador de igualdad para comparar gatos.
        /// </summary>
        public static bool operator ==(Gato g1, Gato g2)
        {
            return g1.Nombre == g2.Nombre && g1.Raza == g2.Raza;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para comparar gatos.
        /// </summary>
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Devuelve una representación de cadena de los datos completos del gato.
        /// </summary>
        public override string ToString()
        {
            return this.DatosCompletos();
        }

        /// <summary>
        /// Determina si el objeto dado es igual al gato actual.
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Gato gato && gato == this;
        }
        #endregion
    }
}

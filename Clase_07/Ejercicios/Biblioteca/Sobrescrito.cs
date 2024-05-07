using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase abstracta que demuestra la sobrescritura de métodos en C#.
    /// </summary>
    public abstract class Sobrescrito
    {
        #region Atributos

        /// <summary>
        /// Atributo protegido utilizado para demostrar sobrescritura.
        /// </summary>
        protected string miAtributo;

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad abstracta que debe ser implementada en clases derivadas.
        /// </summary>
        public abstract string MiPropiedad { get; set; }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Sobrescrito.
        /// </summary>
        public Sobrescrito()
        {
            miAtributo = "Probar abstractos";
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método abstracto que debe ser implementado en clases derivadas.
        /// </summary>
        /// <returns>Una cadena representando el resultado del método.</returns>
        public abstract string MiMetodo();

        #endregion

        #region Sobrescrituras

        /// <summary>
        /// Sobrescribe el método ToString para devolver un mensaje personalizado.
        /// </summary>
        /// <returns>Una cadena que representa el objeto actual.</returns>
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        /// <summary>
        /// Sobrescribe el método Equals para comparar si dos objetos son del mismo tipo.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>true si el objeto es del mismo tipo que este objeto; de lo contrario, false.</returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == GetType();
        }

        /// <summary>
        /// Sobrescribe el método GetHashCode para devolver un valor constante.
        /// </summary>
        /// <returns>Un valor hash constante.</returns>
        public override int GetHashCode()
        {
            return 1142510181;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta que representa una mascota.
    /// </summary>
    public abstract class Mascota
    {
        #region Atributos
        private string _nombre;
        private string _raza;

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el nombre de la mascota.
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        /// <summary>
        /// Obtiene la raza de la mascota.
        /// </summary>
        public string Raza
        {
            get
            {
                return _raza;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Mascota.
        /// </summary>
        /// <param name="nombre">Nombre de la mascota.</param>
        /// <param name="raza">Raza de la mascota.</param>
        public Mascota(string nombre, string raza)
        {
            _nombre = nombre;
            _raza = raza;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método abstracto que devuelve una ficha de la mascota.
        /// </summary>
        /// <returns>Ficha de la mascota.</returns>
        protected abstract string Ficha();

        /// <summary>
        /// Método virtual que devuelve los datos completos de la mascota.
        /// </summary>
        /// <returns>Datos completos de la mascota.</returns>
        protected virtual string DatosCompletos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Raza: {Raza}");

            return stringBuilder.ToString();
        }
        #endregion
    }
}

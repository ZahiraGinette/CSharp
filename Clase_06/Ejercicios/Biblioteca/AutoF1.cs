using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un automóvil de Fórmula 1.
    /// </summary>
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos
        private short caballosDeFuerza;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la cantidad de caballo de fuerza.
        /// </summary>
        public short CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set { caballosDeFuerza = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de la clase AutoF1 con el número de auto y la escudería especificados.
        /// </summary>
        /// <param name="numero">El número del auto.</param>
        /// <param name="escuderia">La escudería a la que pertenece el auto.</param>
        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase AutoF1 con el número de auto, la escudería y los caballos de fuerza especificados.
        /// </summary>
        /// <param name="numero">El número del auto.</param>
        /// <param name="escuderia">La escudería a la que pertenece el auto.</param>
        /// <param name="caballosDeFuerza">Los caballos de fuerza que pertenece al auto.</param>
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos de un Formula 1.
        /// </summary>
        /// <returns>Una cadena que representa los datos del Formula 1.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {CaballosDeFuerza}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return auto1 == auto2 && auto1.caballosDeFuerza == auto2.caballosDeFuerza;
        }

        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
        #endregion
    }
}

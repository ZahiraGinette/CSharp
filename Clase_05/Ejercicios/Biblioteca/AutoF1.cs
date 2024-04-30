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
    public class AutoF1
    {
        #region Atributos
        private short cantidadCombustible;
        private bool enCompotencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la cantidad de combustible del automóvil.
        /// </summary>
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        /// <summary>
        /// Obtiene o establece si el automóvil está en competencia.
        /// </summary>
        public bool EnCompetencia
        {
            get { return enCompotencia; }
            set { enCompotencia = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de vueltas restantes del automóvil.
        /// </summary>
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de la clase AutoF1 con el número de auto y la escudería especificados.
        /// </summary>
        /// <param name="numero">El número del auto.</param>
        /// <param name="escuderia">La escudería a la que pertenece el auto.</param>
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompotencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos del automóvil.
        /// </summary>
        /// <returns>Una cadena que representa los datos del automóvil.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero de auto: {numero}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"En competencia: {enCompotencia}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Comprueba si dos autos de Fórmula 1 son iguales.
        /// </summary>
        /// <param name="autoF1a">El primer auto de Fórmula 1 a comparar.</param>
        /// <param name="autoF1b">El segundo auto de Fórmula 1 a comparar.</param>
        /// <returns>True si los autos son iguales, de lo contrario, False.</returns>
        public static bool operator ==(AutoF1 autoF1a, AutoF1 autoF1b)
        {
            return autoF1a.numero == autoF1b.numero && autoF1a.escuderia == autoF1b.escuderia;
        }

        /// <summary>
        /// Comprueba si dos autos de Fórmula 1 son diferentes.
        /// </summary>
        /// <param name="autoF1a">El primer auto de Fórmula 1 a comparar.</param>
        /// <param name="autoF1b">El segundo auto de Fórmula 1 a comparar.</param>
        /// <returns>True si los autos son diferentes, de lo contrario, False.</returns>
        public static bool operator !=(AutoF1 autoF1a, AutoF1 autoF1b)
        {
            return !(autoF1a == autoF1b);
        }
        #endregion
    }
}

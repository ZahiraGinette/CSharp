using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una competencia de autos de Fórmula 1.
    /// </summary>
    public class Competencia
    {
        #region Atributos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado para evitar instanciación sin parámetros.
        /// </summary>
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Competencia con la cantidad de competidores y la cantidad de vueltas especificadas.
        /// </summary>
        /// <param name="cantidadCompetidores">La cantidad máxima de competidores en la competencia.</param>
        /// <param name="cantidadVueltas">La cantidad de vueltas de la competencia.</param>
        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos de la competencia y de todos los competidores.
        /// </summary>
        /// <returns>Una cadena que representa los datos de la competencia y de todos los competidores.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de vueltas en la competencia: {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");

            foreach (AutoF1 auto in competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Comprueba si un auto de Fórmula 1 está en la competencia.
        /// </summary>
        /// <param name="competencia">La competencia en la que se buscará el auto.</param>
        /// <param name="autoF1">El auto de Fórmula 1 a buscar.</param>
        /// <returns>True si el auto está en la competencia, de lo contrario, False.</returns>
        public static bool operator ==(Competencia competencia, AutoF1 autoF1)
        {
            return competencia.competidores.Contains(autoF1);
        }

        /// <summary>
        /// Comprueba si un auto de Fórmula 1 no está en la competencia.
        /// </summary>
        /// <param name="competencia">La competencia en la que se buscará el auto.</param>
        /// <param name="autoF1">El auto de Fórmula 1 a buscar.</param>
        /// <returns>True si el auto no está en la competencia, de lo contrario, False.</returns>
        public static bool operator !=(Competencia competencia, AutoF1 autoF1)
        {
            return !(competencia == autoF1);
        }

        /// <summary>
        /// Agrega un auto de Fórmula 1 a la competencia si hay espacio disponible y el auto no está ya en la competencia.
        /// </summary>
        /// <param name="competencia">La competencia a la que se agregará el auto.</param>
        /// <param name="autoF1">El auto de Fórmula 1 que se agregará a la competencia.</param>
        /// <returns>True si el auto se agregó correctamente, de lo contrario, False.</returns>
        public static bool operator +(Competencia competencia, AutoF1 autoF1)
        {
            Random combustible = new Random();
            bool resultado = false;

            if (competencia.competidores.Count < competencia.cantidadCompetidores && competencia != autoF1)
            {
                autoF1.EnCompetencia = true;
                autoF1.CantidadCombustible = (short)combustible.Next(15, 100);
                competencia.competidores.Add(autoF1);
                resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Elimina un auto de Fórmula 1 de la competencia si el auto está en la competencia.
        /// </summary>
        /// <param name="competencia">La competencia de la que se eliminará el auto.</param>
        /// <param name="autoF1">El auto de Fórmula 1 que se eliminará de la competencia.</param>
        /// <returns>True si el auto se eliminó correctamente, de lo contrario, False.</returns>
        public static bool operator -(Competencia competencia, AutoF1 autoF1)
        {
            bool resultado = false;

            if (competencia == autoF1)
            {
                competencia.competidores.Remove(autoF1);
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}

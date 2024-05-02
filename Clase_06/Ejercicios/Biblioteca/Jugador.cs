using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un jugador de un equipo.
    /// </summary>
    public class Jugador : Persona
    {
        #region Atributos
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el promedio de goles por partido del jugador.
        /// </summary>
        public float PromedioGoles
        {
            get
            {
                return (float)totalGoles / partidosJugados;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado para evitar instanciación sin parámetros.
        /// </summary>
        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            this.promedioGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Jugador con todos los atributos especificados.
        /// </summary>
        /// <param name="dni">El número de identificación del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        /// <param name="partidosJugados">La cantidad de partidos jugados por el jugador.</param>
        /// <param name="totalGoles">El total de goles anotados por el jugador.</param>
        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos del jugador.
        /// </summary>
        /// <returns>Una cadena que representa los datos del jugador.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total goles: {totalGoles}");
            sb.AppendLine($"Promedio goles: {PromedioGoles}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Comprueba si dos jugadores tienen el mismo DNI.
        /// </summary>
        /// <param name="jugador1">El primer jugador a comparar.</param>
        /// <param name="jugador2">El segundo jugador a comparar.</param>
        /// <returns>True si los jugadores tienen el mismo DNI, de lo contrario, False.</returns>
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.DNI == jugador2.DNI;
        }

        /// <summary>
        /// Comprueba si dos jugadores tienen DNI diferentes.
        /// </summary>
        /// <param name="jugador1">El primer jugador a comparar.</param>
        /// <param name="jugador2">El segundo jugador a comparar.</param>
        /// <returns>True si los jugadores tienen DNI diferentes, de lo contrario, False.</returns>
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un equipo de jugadores.
    /// </summary>
    public class Equipo
    {
        #region Atributos
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado para evitar instanciación sin parámetros.
        /// </summary>
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Equipo con la cantidad de jugadores y el nombre especificados.
        /// </summary>
        /// <param name="cantidadDeJugadores">La cantidad máxima de jugadores que puede tener el equipo.</param>
        /// <param name="nombre">El nombre del equipo.</param>
        public Equipo(short cantidadDeJugadores, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Agrega un jugador al equipo si hay espacio disponible y el jugador no está ya en el equipo.
        /// </summary>
        /// <param name="equipo">El equipo al que se agregará el jugador.</param>
        /// <param name="jugador">El jugador que se agregará al equipo.</param>
        /// <returns>True si el jugador se agregó correctamente, de lo contrario, False.</returns>
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador item in equipo.jugadores)
                {
                    // reutilizo la sobrecarga == de la clase Jugador
                    if (item != jugador)
                    {
                        equipo.jugadores.Add(item);
                        return true; // Retorna verdadero si se agrega el jugador
                    }
                    else
                    {
                        return false; // Retorna falso si el jugador ya está en el equipo
                    }
                }
                // Retorna verdadero si se agrega el jugador (en caso de que el equipo esté vacío)
                equipo.jugadores.Add(jugador);
                return true;
            }
            else
            {
                return false; // Retorna falso si no hay espacio disponible en el equipo
            }
        }
        #endregion
    }
}

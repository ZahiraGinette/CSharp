using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    // <summary>
    /// Representa una canción.
    /// </summary>
    public class Cancion : ElementoMultimedia
    {
        #region Atributos
        private int duracion;
        #endregion

        #region Propiedades
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cancion.
        /// </summary>
        /// <param name="titulo">Título de la canción</param>
        /// <param name="artista">Artista de la canción</param>
        /// <param name="tipo">Género de la canción</param>
        /// <param name="duracion">Duración de la canción en segundos</param>
        public Cancion(string titulo, string artista, EGenero tipo, int duracion)
            : base(titulo, artista, tipo)
        {
            this.duracion = duracion;
        }
        #endregion

        #region Métodos

        #endregion

        #region Sobrecarga de operadores

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una canción.
    /// </summary>
    public class ElementoMultimedia
    {
        #region Atributos
        private string titulo;
        private string artista;
        private EGenero tipo;
        #endregion

        #region Propiedades
        public string Titulo 
        { 
            get { return titulo; }
            set { titulo = value; }
        }
        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public EGenero Genero
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cancion.
        /// </summary>
        /// <param name="titulo">Título de la canción</param>
        /// <param name="artista">Artista de la canción</param>
        /// <param name="duracion">Duración de la canción en minutos</param>
        /// <param name="tipo">Género de la canción</param>
        public ElementoMultimedia(string titulo, string artista, EGenero tipo)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.tipo = tipo;
        }
        #endregion
    }
}

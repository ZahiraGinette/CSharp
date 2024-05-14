using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ListaReproduccion
    {
        #region Atributos
        private string nombre;
        private List<ElementoMultimedia> canciones;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<ElementoMultimedia> Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }
        #endregion

        #region Constructores
        private ListaReproduccion()
        {
            canciones = new List<ElementoMultimedia>();
        }

        /// <summary>
        /// Constructor de la clase ListaReproduccion.
        /// </summary>
        /// <param name="nombre">Nombre de la lista de reproducción</param>
        public ListaReproduccion(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Métodos

        #endregion

        #region Sobrecarga de operadores

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un Camion
    /// </summary>
    public class Furgon : VehiculoTerrestre
    {
        #region Atributos
        private int pesoCarga;
        #endregion

        #region Propiedades
        /// <summary>
        /// El peso de carga máximo del camión
        /// </summary>
        public int PesoCarga { get { return pesoCarga; } set { pesoCarga = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de Camion con la cantidad de ruedas, cantidad de puertas, color, cantidad de marchas y peso de la carga especificado.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del camión</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del camión</param>
        /// <param name="color">El color del camión</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del camión</param>
        /// <param name="pesoCarga">El peso de carga máximo del camión</param>
        public Furgon(short cantidadRuedas, short cantidadPuertas, Colores color,  short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas) 
        {
            this.pesoCarga = pesoCarga;
        }
        #endregion
    }
}

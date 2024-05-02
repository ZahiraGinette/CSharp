using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un automovil
    /// </summary>
    public class Automovil : VehiculoTerrestre
    {
        #region Atributos
        private int cantidadPasajeros;
        #endregion

        #region Propiedades
        /// <summary>
        /// La cantidad de pasajeros que puede transportar el automóvil
        /// </summary>
        public int CantidadPasajeros { get { return cantidadPasajeros; } set { cantidadPasajeros = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de Automovil con la cantidad de ruedas, cantidad de puertas, color, cantidad de marchas y cantidad de pasajeros especificado.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del automóvil</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del automóvil</param>
        /// <param name="color">El color del automóvil</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del automóvil</param>
        /// <param name="cantidadPasajeros">La cantidad de pasajeros que puede transportar el automóvil</param>
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
        #endregion
    }
}

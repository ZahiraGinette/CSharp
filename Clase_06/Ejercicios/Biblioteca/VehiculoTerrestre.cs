using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un vehículo de tipo terrestre
    /// </summary>
    public class VehiculoTerrestre
    {
        #region Atributos
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        #endregion

        #region Propiedades
        /// <summary>
        /// La cantidad de ruedas del vehículo
        /// </summary>
        public short CantidadRuedas { get { return cantidadRuedas; } set { cantidadRuedas = value; } }

        /// <summary>
        /// La cantidad de puertas del vehículo
        /// </summary>
        public short CantidadPuertas { get { return cantidadPuertas; } set { cantidadPuertas = value; } }

        /// <summary>
        /// El color del vehículo
        /// </summary>
        public Colores Color { get { return color; } set { color = value; } }

        /// <summary>
        /// La cantidad de marchas del automóvil
        /// </summary>
        public short CantidadMarchas { get { return cantidadMarchas; } set { cantidadMarchas = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de VehiculoTerrestre con la cantidad de ruedas, cantidad de puertas y color especificado.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del vehículo</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del vehículo</param>
        /// <param name="color">El color del vehículo</param>
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        /// <summary>
        /// Crea una nueva instancia de VehiculoTerrestre con la cantidad de ruedas, cantidad de puertas, color y cantidad de marchas especificado.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas del vehículo</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del vehículo</param>
        /// <param name="color">El color del vehículo</param>
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
        }
        #endregion
    }
}

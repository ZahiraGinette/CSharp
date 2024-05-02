using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una moto
    /// </summary>
    public class Ciclomotor : VehiculoTerrestre
    {
        #region Atributos
        private short cilindrada;
        #endregion

        #region Propiedades
        /// <summary>
        /// La cilindrada de la moto
        /// </summary>
        public short Cilindrada { get { return cilindrada; } set { cilindrada = value; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de Moto con la cantidad de ruedas, cantidad de puertas, color y cilindrado especificado.
        /// </summary>
        /// <param name="cantidadRuedas">La cantidad de ruedas de la moto</param>
        /// <param name="cantidadPuertas">La cantidad de puertas de la moto (si aplica)</param>
        /// <param name="color">El color de la moto</param>
        /// <param name="cilindrada">La cilindrada de la moto</param>
        public Ciclomotor(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color) 
        {
            this.cilindrada = cilindrada;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un vehículo tipo Auto.
    /// </summary>
    public class Auto : Vehiculo
    {
        #region Atributos
        protected int _cantidadAsientos;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Auto.
        /// </summary>
        /// <param name="patente">La patente del auto.</param>
        /// <param name="cantRuedas">La cantidad de ruedas del auto.</param>
        /// <param name="marca">La marca del auto.</param>
        /// <param name="cantidadAsientos">La cantidad de asientos del auto.</param>
        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos)
            : base(patente, cantRuedas, marca)
        {
            _cantidadAsientos = cantidadAsientos;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para mostrar la información del auto.
        /// </summary>
        /// <returns>Una cadena con la información del auto.</returns>
        public string MostrarAuto()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Mostrar());
            stringBuilder.AppendLine($"Cantidad de asientos: {_cantidadAsientos}");

            return stringBuilder.ToString();
        }
        #endregion
    }
}

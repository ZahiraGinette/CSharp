using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un vehículo tipo Camión.
    /// </summary>
    public class Camion : Vehiculo
    {
        #region Atributos
        protected float _tara;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Camion.
        /// </summary>
        /// <param name="patente">La patente del camión.</param>
        /// <param name="cantRuedas">La cantidad de ruedas del camión.</param>
        /// <param name="marca">La marca del camión.</param>
        /// <param name="tara">La tara del camión.</param>
        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara)
            : base(patente, cantRuedas, marca)
        {
            _tara = tara;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para mostrar la información del camión.
        /// </summary>
        /// <returns>Una cadena con la información del camión.</returns>
        public string MostrarCamion()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Mostrar());
            stringBuilder.AppendLine($"Tara: {_tara}");

            return stringBuilder.ToString();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un vehículo tipo Moto.
    /// </summary>
    public class Moto : Vehiculo
    {
        #region Atributos
        protected float _cilindrada;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Moto.
        /// </summary>
        /// <param name="patente">La patente de la moto.</param>
        /// <param name="cantRuedas">La cantidad de ruedas de la moto.</param>
        /// <param name="marca">La marca de la moto.</param>
        /// <param name="cilindrada">La cilindrada de la moto.</param>
        public Moto(string patente, byte cantRuedas, EMarcas marca, float cilindrada)
            : base(patente, cantRuedas, marca)
        {
            _cilindrada = cilindrada;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para mostrar la información de la moto.
        /// </summary>
        /// <returns>Una cadena con la información de la moto.</returns>
        public string MostrarMoto()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Mostrar());
            stringBuilder.AppendLine($"Cilindrada: {_cilindrada}");

            return stringBuilder.ToString();
        }
        #endregion
    }
}

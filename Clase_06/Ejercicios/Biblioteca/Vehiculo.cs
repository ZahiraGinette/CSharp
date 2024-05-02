using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un vehículo.
    /// </summary>
    public class Vehiculo
    {
        #region Atributos
        protected string _patente;
        protected byte _cantidadRuedas;
        protected EMarcas _marca;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de solo lectura que devuelve la patente del vehículo.
        /// </summary>
        public string Patente
        {
            get
            {
                return this._patente;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve la marca del vehículo.
        /// </summary>
        public EMarcas Marca
        {
            get
            {
                return this._marca;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de Vehiculo con la patente, cantidad de puertas y marca especificada.
        /// </summary>
        /// <param name="patente">La patente del vehículo.</param>
        /// <param name="cantRuedas">La cantidad de ruedas del vehículo.</param>
        /// <param name="marca">La marca del vehículo.</param>
        protected Vehiculo(string patente, byte cantidadRuedas, EMarcas marca)
        {
            _patente = patente;
            _cantidadRuedas = cantidadRuedas;
            _marca = marca;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método protegido para mostrar la información del vehículo.
        /// </summary>
        /// <returns>Una cadena con la información del vehículo.</returns>
        protected string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Patente: {_patente}");
            stringBuilder.AppendLine($"Marca: {_marca}");
            stringBuilder.Append($"Cantidad de ruedas: {_cantidadRuedas}");

            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador de igualdad (==) para comparar dos vehículos.
        /// </summary>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1._patente == v2._patente && v1._marca == v2._marca;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad (!=) para comparar dos vehículos.
        /// </summary>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}

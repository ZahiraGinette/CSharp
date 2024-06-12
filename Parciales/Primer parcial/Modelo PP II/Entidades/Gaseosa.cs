using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una gaseosa, derivada de la clase Producto.
    /// </summary>
    public class Gaseosa : Producto
    {
        #region Atributos
        protected float _litros;
        protected static bool _deConsumo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el costo de producción de la gaseosa.
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return Precio * (float)1.42;
            }
            set
            {
                Precio = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de la clase gaseosa.
        /// </summary>
        public Gaseosa() { }

        /// <summary>
        /// Constructor estático de la clase Gaseosa.
        /// </summary>
        static Gaseosa()
        {
            _deConsumo = true;
        }

        /// <summary>
        /// Constructor de instancia de la clase Gaseosa.
        /// </summary>
        /// <param name="codigoBarra">Código de barras de la gaseosa.</param>
        /// <param name="precio">Precio de la gaseosa.</param>
        /// <param name="marca">Marca de la gaseosa.</param>
        /// <param name="litros">Cantidad de litros de la gaseosa.</param>
        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            _litros = litros;
        }

        public Gaseosa(Producto producto, float litros)
            : this(producto.CodigoDeBarra, producto.Precio, producto.Marca, litros) 
        {

        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra los detalles de la gaseosa.
        /// </summary>
        /// <returns>Una cadena con los detalles de la gaseosa.</returns>
        private string MostrarGaseosa()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append((string)this);
            retorno.AppendFormat("Litros: {0}ls\n", _litros);
            retorno.AppendLine($"De consumo: {_deConsumo}");

            return retorno.ToString();
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Devuelve una cadena que representa a la gaseosa.
        /// </summary>
        /// <returns>Una cadena que representa a la gaseosa.</returns>
        public override string ToString()
        {
            return MostrarGaseosa();
        }

        /// <summary>
        /// Describe el consumo de la gaseosa.
        /// </summary>
        /// <returns>Una cadena que describe el consumo de la gaseosa.</returns>
        public override string Consumir()
        {
            return "Bebible";
        }
        #endregion
    }
}

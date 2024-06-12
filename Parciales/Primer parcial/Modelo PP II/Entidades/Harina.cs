using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa la harina, derivada de la clase Producto.
    /// </summary>
    public class Harina : Producto
    {
        #region Atributos
        protected ETipoHarina _tipo;
        protected static bool _deConsumo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el costo de producción de la harina.
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return Precio * 1.6f;
            }
            set
            {
                Precio = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de la clase Harina.
        /// </summary>
        public Harina() { }

        /// <summary>
        /// Constructor estático de la clase Harina.
        /// </summary>
        static Harina()
        {
            _deConsumo = false;
        }

        /// <summary>
        /// Constructor de instancia de la clase Harina.
        /// </summary>
        /// <param name="codigo">Código de barras de la harina.</param>
        /// <param name="precio">Precio de la harina.</param>
        /// <param name="marca">Marca de la harina.</param>
        /// <param name="tipo">Tipo de harina.</param>
        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigo, marca, precio)
        {
            _tipo = tipo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra los detalles de la harina.
        /// </summary>
        /// <returns>Una cadena con los detalles de la harina.</returns>
        private string MostrarHarina()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append((string)this);
            retorno.AppendLine($"Tipo: {_tipo}");
            retorno.AppendLine($"De consumo: {_deConsumo}");

            return retorno.ToString();
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Devuelve una cadena que representa a la harina.
        /// </summary>
        /// <returns>Una cadena que representa a la harina.</returns>
        public override string ToString()
        {
            return MostrarHarina();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa un jugo, derivada de la clase Producto.
    /// </summary>
    public class Jugo : Producto
    {
        #region Atributos
        protected ESaborJugo _sabor;
        protected static bool _deConsumo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el costo de producción del jugo.
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return _precio * 0.40f;
            }
            set
            {
                Precio = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de la clase Jugo
        /// </summary>
        public Jugo() { }

        /// <summary>
        /// Constructor estático de la clase Jugo.
        /// </summary>
        static Jugo()
        {
            _deConsumo = true;
        }

        /// <summary>
        /// Constructor de instancia de la clase Jugo.
        /// </summary>
        /// <param name="codigoBarra">Código de barras del jugo.</param>
        /// <param name="precio">Precio del jugo.</param>
        /// <param name="marca">Marca del jugo.</param>
        /// <param name="sabor">Sabor del jugo.</param>
        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            _sabor = sabor;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra los detalles del jugo.
        /// </summary>
        /// <returns>Una cadena con los detalles del jugo.</returns>
        private string MostrarJugo()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append((string)this);
            retorno.AppendFormat("Sabor: {0}\n", _sabor);
            retorno.AppendLine($"De consumo: {_deConsumo}");

            return retorno.ToString();
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Devuelve una cadena que representa al jugo.
        /// </summary>
        /// <returns>Una cadena que representa al jugo.</returns>
        public override string ToString()
        {
            return MostrarJugo();
        }

        /// <summary>
        /// Describe el consumo del jugo.
        /// </summary>
        /// <returns>Una cadena que describe el consumo del jugo.</returns>
        public override string Consumir()
        {
            return "Bebible";
        }
        #endregion
    }
}

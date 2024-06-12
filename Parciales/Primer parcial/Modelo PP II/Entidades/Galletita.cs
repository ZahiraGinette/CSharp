using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una galletita, derivada de la clase Producto.
    /// </summary>
    public class Galletita : Producto
    {
        #region Atributos
        protected float _peso;
        protected static bool _deConsumo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el costo de producción de la galletita.
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return Precio * 1.33f;
            }
            set
            {
                Precio = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de la clase Galletita.
        /// </summary>
        public Galletita() { }

        /// <summary>
        /// Constructor estático de la clase Galletita.
        /// </summary>
        static Galletita()
        {
            _deConsumo = true;
        }

        /// <summary>
        /// Constructor de instancia de la clase Galletita.
        /// </summary>
        /// <param name="codigoBarra">Código de barras de la galletita.</param>
        /// <param name="precio">Precio de la galletita.</param>
        /// <param name="marca">Marca de la galletita.</param>
        /// <param name="peso">Peso de la galletita.</param>
        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            _peso = peso;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra los detalles de la galletita.
        /// </summary>
        /// <returns>Una cadena con los detalles de la galletita.</returns>
        private static string MostrarGalletita(Galletita galletita)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append((string)galletita);
            retorno.AppendFormat("Peso: {0:##.##}kg\n", galletita._peso);
            retorno.AppendLine($"De consumo: {_deConsumo}");

            return retorno.ToString();
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Devuelve una cadena que representa a la galletita.
        /// </summary>
        /// <returns>Una cadena que representa a la galletita.</returns>
        public override string ToString()
        {
            return MostrarGalletita(this);
        }

        /// <summary>
        /// Describe el consumo de la galletita.
        /// </summary>
        /// <returns>Una cadena que describe el consumo de la galletita.</returns>
        public override string Consumir()
        {
            return "Comestible";
        }
        #endregion
    }
}

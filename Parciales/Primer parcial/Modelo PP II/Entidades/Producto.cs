using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta que representa un producto.
    /// </summary>
    public abstract class Producto
    {
        #region Atributos
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene la marca del producto.
        /// </summary>
        public EMarcaProducto Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        /// <summary>
        /// Obtiene el precio del producto.
        /// </summary>
        public float Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        /// <summary>
        /// Obtiene el código de barras del producto.
        /// </summary>
        public int CodigoDeBarra
        {
            get
            {
                return _codigoDeBarra;
            }
            set
            {
                _codigoDeBarra = value;
            }
        }

        /// <summary>
        /// Propiedad abstracta para calcular el costo de producción del producto.
        /// </summary>
        public abstract float CalcularCostoDeProduccion { get; set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de la clase Producto.
        /// </summary>
        public Producto() { }

        /// <summary>
        /// Constructor de la clase Producto.
        /// </summary>
        /// <param name="codigoBarra">Código de barras del producto.</param>
        /// <param name="marca">Marca del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            _precio = precio;
            _marca = marca;
            _codigoDeBarra = codigoBarra;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra los detalles del producto.
        /// </summary>
        /// <param name="p">Producto a mostrar.</param>
        /// <returns>Una cadena con los detalles del producto.</returns>
        private static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {p.Marca}");
            sb.AppendLine($"Código: {p.CodigoDeBarra}");
            sb.AppendFormat("Precio: ${0:##.##}\n", p.Precio);

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Compara si dos productos son iguales.
        /// </summary>
        /// <param name="p1">Primer producto.</param>
        /// <param name="p2">Segundo producto.</param>
        /// <returns>True si son iguales, de lo contrario false.</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.GetType() == p2.GetType() && p1.Marca == p2.Marca && p1.CodigoDeBarra == p2.CodigoDeBarra;
        }

        /// <summary>
        /// Compara si dos productos son diferentes.
        /// </summary>
        /// <param name="p1">Primer producto.</param>
        /// <param name="p2">Segundo producto.</param>
        /// <returns>True si son diferentes, de lo contrario false.</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Compara si un producto es de una determinada marca.
        /// </summary>
        /// <param name="producto">Producto a comparar.</param>
        /// <param name="marca">Marca a comparar.</param>
        /// <returns>True si el producto es de la marca, de lo contrario false.</returns>
        public static bool operator ==(Producto producto, EMarcaProducto marca)
        {
            return producto.Marca == marca;
        }

        /// <summary>
        /// Compara si un producto no es de una determinada marca.
        /// </summary>
        /// <param name="producto">Producto a comparar.</param>
        /// <param name="marca">Marca a comparar.</param>
        /// <returns>True si el producto no es de la marca, de lo contrario false.</returns>
        public static bool operator !=(Producto producto, EMarcaProducto marca)
        {
            return !(producto == marca);
        }

        /// <summary>
        /// Convierte explícitamente un producto a su código de barras.
        /// </summary>
        /// <param name="producto">Producto a convertir.</param>
        public static explicit operator int(Producto producto)
        {
            return producto.CodigoDeBarra;
        }

        /// <summary>
        /// Convierte implícitamente un producto a una cadena que muestra sus detalles.
        /// </summary>
        /// <param name="producto">Producto a convertir.</param>
        public static implicit operator string(Producto producto)
        {
            return MostrarProducto(producto);
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Determina si el objeto especificado es igual al objeto actual.
        /// </summary>
        /// <param name="obj">El objeto a comparar con el objeto actual.</param>
        /// <returns>True si el objeto especificado es igual al objeto actual, de lo contrario false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Producto && this == (Producto)obj;
        }

        /// <summary>
        /// Método virtual que describe el consumo del producto.
        /// </summary>
        /// <returns>Una cadena que describe el consumo del producto.</returns>
        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }
        #endregion
    }
}

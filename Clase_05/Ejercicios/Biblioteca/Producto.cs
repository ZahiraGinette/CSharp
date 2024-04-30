using System;
using System.Text;

namespace Biblioteca
{
    /// <summary>
    /// Representa un producto.
    /// </summary>
    public class Producto
    {
        #region Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de instancia de la clase Producto.
        /// </summary>
        /// <param name="codigoDeBarra">Código de barras del producto.</param>
        /// <param name="marca">Marca del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Obtiene la marca del producto.
        /// </summary>
        /// <returns>Marca del producto.</returns>
        public string GetMarca()
        {
            return marca;
        }

        /// <summary>
        /// Obtiene el precio del producto.
        /// </summary>
        /// <returns>Precio del producto.</returns>
        public float GetPrecio()
        {
            return precio;
        }

        /// <summary>
        /// Muestra los detalles del producto.
        /// </summary>
        /// <param name="producto">Producto a mostrar.</param>
        /// <returns>Detalles del producto.</returns>
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Código de barras: {producto.codigoDeBarra}");
            stringBuilder.AppendLine($"Marca: {producto.marca}");
            stringBuilder.Append($"Precio: ${producto.precio}");
            return stringBuilder.ToString();
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Convierte un objeto Producto a un string, devolviendo el código de barras.
        /// </summary>
        /// <param name="producto">Producto a convertir.</param>
        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        /// <summary>
        /// Comprueba si dos productos tienen la misma marca y código de barras.
        /// </summary>
        /// <param name="producto1">Primer producto a comparar.</param>
        /// <param name="producto2">Segundo producto a comparar.</param>
        /// <returns>True si los productos son iguales, False en caso contrario.</returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (!(producto1 is null || producto2 is null))
            {
                return (producto1.marca == producto2.marca && producto1.codigoDeBarra == producto2.codigoDeBarra);
            }
            return false;
        }

        /// <summary>
        /// Comprueba si dos productos no son iguales en marca y código de barras.
        /// </summary>
        /// <param name="producto1">Primer producto a comparar.</param>
        /// <param name="producto2">Segundo producto a comparar.</param>
        /// <returns>True si los productos son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        /// <summary>
        /// Comprueba si un producto tiene la misma marca que una cadena dada.
        /// </summary>
        /// <param name="producto">Producto a comparar.</param>
        /// <param name="marca">Marca a comparar.</param>
        /// <returns>True si la marca del producto coincide con la cadena dada, False en caso contrario.</returns>
        public static bool operator ==(Producto producto, string marca)
        {
            return producto.marca == marca;
        }

        /// <summary>
        /// Comprueba si un producto no tiene la misma marca que una cadena dada.
        /// </summary>
        /// <param name="producto">Producto a comparar.</param>
        /// <param name="marca">Marca a comparar.</param>
        /// <returns>True si la marca del producto no coincide con la cadena dada, False en caso contrario.</returns>
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }

        #endregion
    }
}

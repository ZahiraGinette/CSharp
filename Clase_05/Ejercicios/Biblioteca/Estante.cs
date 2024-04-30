using System;
using System.Text;

namespace Biblioteca
{
    /// <summary>
    /// Representa un estante para almacenar productos.
    /// </summary>
    public class Estante
    {
        #region Atributos

        private Producto[] productos;
        private int ubicacionEstante;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de instancia privado que inicializa el array de productos.
        /// </summary>
        /// <param name="capacidad">Capacidad del estante.</param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Constructor de instancia pública que inicializa la ubicación del estante y reutiliza el constructor privado para inicializar el array de productos.
        /// </summary>
        /// <param name="capacidad">Capacidad del estante.</param>
        /// <param name="ubicacionEstante">Ubicación del estante.</param>
        public Estante(int capacidad, int ubicacionEstante) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Obtiene el array de productos del estante.
        /// </summary>
        /// <returns>Array de productos del estante.</returns>
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /// <summary>
        /// Muestra la información del estante, incluyendo el detalle de cada uno de sus productos.
        /// </summary>
        /// <param name="estante">Estante a mostrar.</param>
        /// <returns>Información del estante.</returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Ubicación del estante: {estante.ubicacionEstante}");
            stringBuilder.AppendLine("Productos:");
            foreach (Producto producto in estante.productos)
            {
                stringBuilder.AppendLine(Producto.MostrarProducto(producto));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Obtiene la cantidad de productos presentes en el estante.
        /// </summary>
        /// <returns>Cantidad de productos presentes en el estante.</returns>
        private int CantidadProductos()
        {
            int cantidad = 0;
            foreach (Producto producto in this.productos)
            {
                if ((object)producto != null) // Cambiado a comparación directa con null
                    cantidad++;
            }
            return cantidad;
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Comprueba si un producto ya se encuentra en el estante.
        /// </summary>
        /// <param name="estante">Estante a verificar.</param>
        /// <param name="producto">Producto a buscar.</param>
        /// <returns>True si el producto está en el estante, False en caso contrario.</returns>
        public static bool operator ==(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Comprueba si un producto no se encuentra en el estante.
        /// </summary>
        /// <param name="estante">Estante a verificar.</param>
        /// <param name="producto">Producto a buscar.</param>
        /// <returns>True si el producto no está en el estante, False en caso contrario.</returns>
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        /// <summary>
        /// Agrega un producto al estante si hay capacidad y el producto no está presente en el estante.
        /// </summary>
        /// <param name="estante">Estante al que se desea agregar el producto.</param>
        /// <param name="producto">Producto a agregar.</param>
        /// <returns>True si se agregó el producto, False en caso contrario.</returns>
        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        return true;

                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Quita un producto del estante si está presente en el mismo.
        /// </summary>
        /// <param name="estante">Estante del que se desea quitar el producto.</param>
        /// <param name="producto">Producto a quitar.</param>
        /// <returns>Estante sin el producto si se quitó, o el estante original si el producto no estaba presente.</returns>
        public static Estante operator -(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante == producto)
                {
                    estante.productos[i] = null;
                    break;
                }
            }
            return estante;
        }

        #endregion
    }
}

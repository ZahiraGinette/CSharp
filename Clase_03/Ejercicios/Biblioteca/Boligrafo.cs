using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un bolígrafo con capacidad para escribir utilizando tinta.
    /// </summary>
    public class Boligrafo
    {
        #region Atributos
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de Boligrafo con el color especificado y la cantidad inicial de tinta.
        /// </summary>
        /// <param name="color">Color del bolígrafo.</param>
        /// <param name="tintaInicial">Cantidad inicial de tinta.</param>
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Obtiene el color del bolígrafo.
        /// </summary>
        /// <returns>Color del bolígrafo.</returns>
        public ConsoleColor GetColor()
        {
            return color;
        }

        /// <summary>
        /// Obtiene la cantidad de tinta restante en el bolígrafo.
        /// </summary>
        /// <returns>Cantidad de tinta restante.</returns>
        public int GetTinta()
        {
            return tinta;
        }
        #endregion

        #region Setters
        /// <summary>
        /// Establece la cantidad de tinta del bolígrafo.
        /// </summary>
        /// <param name="cantidad">Cantidad de tinta.</param>
        private void SetTinta(short cantidad)
        {
            if (cantidad >= 0 && cantidad <= cantidadTintaMaxima)
            {
                tinta = cantidad;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Recarga la tinta del bolígrafo al nivel máximo.
        /// </summary>
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// Pinta con el bolígrafo utilizando la cantidad de tinta especificada.
        /// </summary>
        /// <param name="gasto">Cantidad de tinta a utilizar.</param>
        /// <param name="dibujo">Resultado de la acción de pintar.</param>
        /// <returns>True si pudo pintar, False si no hay suficiente tinta.</returns>
        /// <remarks>
        /// Si el gasto es mayor que la cantidad de tinta restante, se utilizará toda la tinta restante.
        /// </remarks>
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            if (gasto > 0 && gasto <= tinta)
            {
                short nuevaTinta = (short)(tinta - (short)gasto);
                this.SetTinta(nuevaTinta);

                dibujo = new string('*', gasto);
                return true;                
            } 
            else
            {
                dibujo = new string('*', tinta);
                return false;
            }

        }
        #endregion
    }
}

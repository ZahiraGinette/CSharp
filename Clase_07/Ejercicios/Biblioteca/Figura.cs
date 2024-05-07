using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase abstracta que representa una figura geométrica.
    /// </summary>
    public abstract class Figura
    {
        #region Métodos

        /// <summary>
        /// Dibuja la figura.
        /// </summary>
        /// <returns>Una cadena que representa el proceso de dibujo.</returns>
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        /// <summary>
        /// Calcula el área de la figura.
        /// </summary>
        /// <returns>El área de la figura.</returns>
        public abstract double CalcularSuperficie();

        /// <summary>
        /// Calcula el perímetro de la figura.
        /// </summary>
        /// <returns>El perímetro de la figura.</returns>
        public abstract double CalcularPerimetro();

        #endregion
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un rectángulo.
    /// </summary>
    public class Rectangulo : Figura
    {
        #region Atributos
        private float longitudBase;
        private float longitudAltura;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Rectangulo.
        /// </summary>
        /// <param name="longitudBase">La longitud de la base del rectángulo.</param>
        /// <param name="longitudAltura">La longitud de la altura del rectángulo.</param>
        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Dibuja el rectángulo.
        /// </summary>
        /// <returns>Una cadena que representa el proceso de dibujo del rectángulo.</returns>
        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }

        /// <summary>
        /// Calcula el perímetro del rectángulo.
        /// </summary>
        /// <returns>El perímetro del rectángulo.</returns>
        public override double CalcularPerimetro()
        {
            return (this.longitudBase + this.longitudAltura) * 2;
        }

        /// <summary>
        /// Calcula el área del rectángulo.
        /// </summary>
        /// <returns>El área del rectángulo.</returns>
        public override double CalcularSuperficie()
        {
            return this.longitudBase * this.longitudAltura;
        }

        #endregion
    }
}

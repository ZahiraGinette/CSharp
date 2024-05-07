using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un círculo.
    /// </summary>
    public class Circulo : Figura
    {
        #region Atributos

        /// <summary>
        /// El radio del círculo.
        /// </summary>
        private float radio;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Circulo.
        /// </summary>
        /// <param name="radio">El radio del círculo.</param>
        public Circulo(float radio)
        {
            this.radio = radio;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Dibuja el círculo.
        /// </summary>
        /// <returns>Una cadena que representa el proceso de dibujo del círculo.</returns>
        public override string Dibujar()
        {
            return "Dibujando Circulo...";
        }

        /// <summary>
        /// Calcula el perímetro del círculo.
        /// </summary>
        /// <returns>El perímetro del círculo.</returns>
        public override double CalcularPerimetro()
        {
            return Math.PI * this.radio * 2;
        }

        /// <summary>
        /// Calcula el área del círculo.
        /// </summary>
        /// <returns>El área del círculo.</returns>
        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        #endregion
    }

}

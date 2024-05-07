using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un cuadrado.
    /// </summary>
    public class Cuadrado : Rectangulo
    {
        #region Constructores

        /// <summary>
        /// Constructor de la clase Cuadrado.
        /// </summary>
        /// <param name="longitudLado">La longitud del lado del cuadrado.</param>
        public Cuadrado(float longitudLado) : base(longitudLado, longitudLado)
        {

        }

        #endregion

        #region Métodos

        /// <summary>
        /// Dibuja el cuadrado.
        /// </summary>
        /// <returns>Una cadena que representa el proceso de dibujo del cuadrado.</returns>
        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }

        #endregion
    }

}

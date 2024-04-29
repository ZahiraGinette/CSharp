using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    /// <summary>
    /// Clase que proporciona métodos para calcular áreas de diferentes formas geométricas.
    /// </summary>
    public class CalculoDeArea
    {
        /// <summary>
        /// Calcula el área de un cuadrado.
        /// </summary>
        /// <param name="longitudLado">La longitud del lado del cuadrado.</param>
        /// <returns>El área del cuadrado.</returns>
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double retorno = 0;
            retorno = Math.Pow(longitudLado, 2);
            return retorno;
        }

        /// <summary>
        /// Calcula el área de un triángulo.
        /// </summary>
        /// <param name="xbase">La longitud de la base del triángulo.</param>
        /// <param name="altura">La altura del triángulo.</param>
        /// <returns>El área del triángulo.</returns>
        public static double CalcularAreaTriangulo(double xbase, double altura)
        {
            double retorno = 0;
            retorno = (xbase * altura) / 2;
            return retorno;
        }

        /// <summary>
        /// Calcula el área de un círculo.
        /// </summary>
        /// <param name="radio">El radio del círculo.</param>
        /// <returns>El área del círculo.</returns>
        public static double CalcularAreaCirculo(double radio)
        {
            double retorno = 0;
            retorno = Math.PI * Math.Pow(radio, 2);
            return retorno;
        }
    }
}

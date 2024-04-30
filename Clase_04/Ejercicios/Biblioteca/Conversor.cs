using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una conversión entre números decimales y binarios.
    /// </summary>
    public class Conversor
    {
        #region Métodos
        /// <summary>
        /// Convierte un número entero del sistema decimal al sistema binario.
        /// </summary>
        /// <param name="numeroEntero">El número entero a convertir.</param>
        /// <returns>Una cadena que representa el número binario resultante.</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            return Convert.ToString(numeroEntero, 2);
        }

        /// <summary>
        /// Convierte una cadena binaria al sistema decimal.
        /// </summary>
        /// <param name="numeroBinario">La cadena binaria a convertir.</param>
        /// <returns>El número decimal resultante.</returns>
        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            return Convert.ToInt32(numeroBinario, 2);
        }
        #endregion
    }
}

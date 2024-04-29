using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    /// <summary>
    /// Clase que proporciona métodos para convertir números entre decimal y binario.
    /// </summary>
    public class Conversor
    {
        /// <summary>
        /// Convierte un número decimal en su representación binaria.
        /// </summary>
        /// <param name="numeroEntero">El número entero a convertir.</param>
        /// <returns>Una cadena que representa el número en binario.</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            if (numeroEntero == 0)
                return "0";

            string binario = "";
            while (numeroEntero > 0)
            {
                int residuo = numeroEntero % 2;
                binario = residuo + binario;
                numeroEntero /= 2;
            }
            return binario;
        }

        /// <summary>
        /// Convierte un número binario en su equivalente decimal.
        /// </summary>
        /// <param name="numeroBinario">El número binario a convertir.</param>
        /// <returns>El número decimal equivalente.</returns>
        public static int ConvertirBinarioADecimal(int numeroBinario)
        {
            int decimalResult = 0;
            int potencia = 0;

            while (numeroBinario != 0)
            {
                int digito = numeroBinario % 10;
                decimalResult += digito * (int)Math.Pow(2, potencia);
                numeroBinario /= 10;
                potencia++;
            }

            return decimalResult;
        }
    }
}

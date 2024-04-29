using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    /// <summary>
    /// Clase que proporciona métodos para validar un número dentro de un rango especificado.
    /// </summary>
    public class Validacion
    {
        /// <summary>
        /// Valida si un número está dentro del rango especificado.
        /// </summary>
        /// <param name="numero">El número a validar.</param>
        /// <param name="minimo">El valor mínimo del rango.</param>
        /// <param name="maximo">El valor máximo del rango.</param>
        /// <returns>True si el número está dentro del rango, False de lo contrario.</returns>
        public static bool Validar(int numero, int minimo, int maximo)
        {
            bool retorno = true;
            if (numero > maximo || numero < minimo)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}

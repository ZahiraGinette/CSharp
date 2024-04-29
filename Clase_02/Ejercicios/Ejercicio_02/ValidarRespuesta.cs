using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    /// <summary>
    /// Clase que proporciona métodos para validar respuestas S/N.
    /// </summary>
    public class ValidarRespuesta
    {
        /// <summary>
        /// Valida si la respuesta proporcionada es 's' o 'S'.
        /// </summary>
        /// <param name="respuesta">La respuesta a validar.</param>
        /// <returns>True si la respuesta es 's' o 'S', False de lo contrario.</returns>
        public static bool Validar(char respuesta)
        {
            bool retorno = false;
            if (respuesta == 's' || respuesta == 'S')
            {
                retorno = true;
            }

            return retorno;
        }
    }
}

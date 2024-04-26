using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class Validacion
    {
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

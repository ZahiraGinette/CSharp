using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    public class CalculoDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double retorno = 0;
            retorno = Math.Pow(longitudLado, 2);
            return retorno;
        }

        public static double CalcularAreaTriangulo(double xbase, double altura)
        {
            double retorno = 0;
            retorno = (xbase * altura) / 2;
            return retorno;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double retorno = 0;
            retorno = Math.PI * Math.Pow(radio, 2);
            return retorno;
        }
    }
}

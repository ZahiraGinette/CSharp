using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    public class Conversor
    {
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

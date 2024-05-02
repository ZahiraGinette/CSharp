using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorConversionMain
{
    public class SegundaClase
    {
        public SegundaClase() 
        { 
        
        }

        public static explicit operator PrimeraClase(SegundaClase segundaClase)
        {
            return new PrimeraClase();
        }

        public static explicit operator int(SegundaClase segundaClase)
        {
            return 8;
        }

        public static explicit operator string(SegundaClase segundaClase)
        {
            return "Es un string.";
        }


        public static string operator -(SegundaClase segundaClase, int numero)
        {
            return "Hola" + numero;
        }
        

    }
}

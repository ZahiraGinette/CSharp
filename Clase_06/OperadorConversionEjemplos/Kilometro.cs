using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorConversion_ejemplos
{
    public class Kilometro
    {
        private double kilometro;

        public double Longitud
        {
            get { return kilometro; }
            set { kilometro = value; }
        }
        public Kilometro(double longitud)
        {
            if (longitud < 0) 
              longitud = 0;
            else
            {
               kilometro = longitud;
            }
            
        }

        // Conversión explícita de Kilometro a Metro
        public static explicit operator Metro(Kilometro k)
        {
            return new Metro(k.Longitud * 1000);
        }

        // Conversión implícita de Kilometro a double
        public static implicit operator double(Kilometro k)
        {
            return k.Longitud;
        }
    }
}

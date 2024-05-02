using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorConversion_ejemplos
{
    public class Metro
    {

        private double longitud;

        public Metro(double longitud)
        {
            this.longitud = longitud; 
        }

        public double Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                longitud = value;
            }
        }

        // Conversion implicita de Metro a double
        public static implicit operator double(Metro m)
        {
            return m.longitud;
        }

        // Conversion implicita de Metro a Kilometro
        public static implicit operator Kilometro(Metro m)
        {
            return new Kilometro(m.longitud / 1000);
        }


    }
}

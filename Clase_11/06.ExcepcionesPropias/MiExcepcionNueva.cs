using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Excepciones_propias
{
    public class MiExcepcionNueva : Exception
    {
        public MiExcepcionNueva() 
        { 
        
        }
        public MiExcepcionNueva(string mensaje) : base(mensaje)
        {

        }

        public MiExcepcionNueva(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}

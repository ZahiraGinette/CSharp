using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Interfaces
{
    class Email : ClaseAbstracta,IMensaje
    {
        public string EnviarMensaje()
        {
            return "Para cuando van a estar las notas?? >:(";
        }

        public override string MostrarEmail()
        {
            return "El mail es prueba@hotmail.com";
        }
    }
}

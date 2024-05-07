using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Polimorfismo_basado_herencia
{
    public class Animal
    {
        // VIRTUAL -> Metodo que puede ser invalidao/redefinido/sobrescrito
        public virtual string EmitirSonido()
        {
            return "¡Rrr!";
        }

        public virtual void MostrarMensaje()
        {
            Console.WriteLine("Mensaje de animal");
        }
    }
}

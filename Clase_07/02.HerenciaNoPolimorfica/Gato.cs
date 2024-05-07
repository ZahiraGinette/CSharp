using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Herencia_no_polimorfica
{
    public class Gato : Animal
    { 
        // No se aplica polimorfismo
        public new string EmitirSonido()
        {
            return "¡Miau!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Polimorfismo_basado_herencia
{
    public class Gato : Animal
    {
        // Se aplica polimorfismo
        // OVERRIDE -> Se usa para invalidar/redefinir/sobrescribir un metodo virtual de la clase BASE
        //public override void EmitirSonido()
        //{
        //    Console.WriteLine("¡Miau!");
        //}

        public override string EmitirSonido()
        {
            return "¡Miau!";
        }

 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Enumerados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Color.Rojo);
            Console.WriteLine((Color)1);
            Console.WriteLine((int)Color.Azul);

            Console.WriteLine(TipoDocumento.Dni);
            Console.WriteLine((TipoDocumento)1);
            Console.WriteLine((int)TipoDocumento.Extranjero);
        }

        public enum Color
        {
            Rojo,
            Amarillo,
            Verde,
            Azul,
            Violeta
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Impresora impresoraDos = new Impresora("Ejemplo", "Modelo");

            Impresora impresoraTres = new Impresora("Ejemplo", "Modelo", 10000);

            Impresora impresoraCuatro = new Impresora("Ejemplo", "Modelo", false, 9);
        }

    }
}

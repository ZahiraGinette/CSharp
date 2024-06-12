using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> a = new Queue<string>();
            a.Enqueue("a");
            a.Enqueue("b");
            a.Enqueue("c");

            while (a.Count > 0)
            {
                Console.WriteLine(a.Dequeue().ToString());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Método para ordenar productos por su código de barras.
        /// </summary>
        /// <param name="x">Primer producto a comparar.</param>
        /// <param name="y">Segundo producto a comparar.</param>
        /// <returns>Entero que indica la comparación entre los productos.</returns>
        public static int OrdenarProductos(Producto x, Producto y)
        {
            int retorno = 0;

            if (x.CodigoDeBarra > y.CodigoDeBarra)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }


    }
}

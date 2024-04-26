using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso
{
    public class Program // Clase program
    {
        // El metodo MAIN es un metodo estatico, que esta dentro de la clase PROGRAM
        static void Main(string[] args)
        {
        }


        // PUBLIC => Modificador de acceso
        // DOUBLE => Lo que retornara el metodo
        // HARMONIC => Nombre del metodo
        public static double harmonic(int numero) // int es el tipo del parametro y n es el nombre del parametro
        {
            double sum = 0.0; // Se crea una variable local ( solo existira en el metodo )
            for (int i = 1; i <= numero; i++)
            {
                sum += 1.0 / i;
            }

            return sum; // retorno del metodo
        }

        /* **** Modificadores de acceso **** */

        public void MetodoPublico()
        {
            Console.WriteLine("Esto es un metodo publico");
        }

        private void MetodoPrivado()
        {
            Console.WriteLine("Esto es un metodo privado");
        }

        internal void MetodoInternal()
        {
            Console.WriteLine("Esto es un metodo internal");
        }

        protected void MetodoProtected()
        {
            Console.WriteLine("Esto es un metodo protected");
        }
    }
}

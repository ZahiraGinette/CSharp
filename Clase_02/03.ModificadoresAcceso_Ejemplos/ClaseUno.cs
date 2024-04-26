using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso_Ejemplos
{
    public class ClaseUno
    {
        public static void MetodoUno()
        {
            Console.WriteLine("Es un metodo public");
        }
        private static void MetodoDos()
        {
            Console.WriteLine("Es un metodo private");
        }
        internal static void MetodoTres()
        {
            Console.WriteLine("Es un metodo internal");
        }
        protected static void MetodoCuatro()
        {
            Console.WriteLine("Es un metodo protected");
        }

        public void EjemploPrivado()
        {
            MetodoDos(); // Se puede definir el metodo porque lo llama de la misma clase 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo operadores
            var datoUno = 1;
            var datoDos = 3;

            if (datoUno > datoDos)
            {
                // ...
            }

            if (datoUno < datoDos)
            {
                // ...
            }

            if (datoUno >= datoDos)
            {
                // ...
            }

            if (datoUno <= datoDos)
            {
                // ...
            }

            if (datoUno == datoDos)
            {
                // ...
            }


            if (datoUno != datoDos)
            {
                // ...
            }

            if(MetodoDos() && MetodoUno())
            {
                //****
            }

            if (MetodoDos() || MetodoUno())
            {
                //****
            }

            bool MetodoUno()
            {
                return true;     
            }

            bool MetodoDos()
            {
                return false;
            }
        }
    }
}

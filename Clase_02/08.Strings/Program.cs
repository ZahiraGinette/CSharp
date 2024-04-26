using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "StringBuilder";

            string mensajeUno = "Hola ";
            string mensajeDos = "mundo!";
            // Al hacer esto se esta creando un nuevo objeto de tipo string en memoria y se reasigna
            // a la variable incial mensajeUno
            /* mensajeUno += mensajeDos;  

             Console.WriteLine(mensajeUno);


             #region Ejemplo String
             int contador = 0;
             while (contador < 1000)
             {
                 mensajeUno += "X"; // Esto no tiene un gran rendimiento 
                 contador++;
             }

             Console.WriteLine(mensajeUno);
             Console.ReadKey();
             #endregion
            */

            #region StringBuilder
            StringBuilder stringBuilder = new StringBuilder("Comienzo del string");

            int contadorDos = 0;
            while (contadorDos < 1000)
            {
                stringBuilder.AppendLine("l");
                contadorDos++;
            }

            Console.WriteLine(stringBuilder.ToString());
            Console.ReadKey();

            //Agrega texto al final del objeto stringbuilder 
            StringBuilder total = new StringBuilder("El total es ");
            int totalCuenta = 90;
            int segundoTotal = 20;
            total.AppendFormat("{0}, el segundo total es {1}", totalCuenta.ToString(), segundoTotal.ToString());

            Console.WriteLine(total.ToString());
            Console.ReadKey();

            StringBuilder total2 = new StringBuilder("El total es 35");

            total.Insert(2, " de la cuenta ");

            Console.WriteLine(total2.ToString());
            Console.ReadKey();

            #endregion
        }
    }
}

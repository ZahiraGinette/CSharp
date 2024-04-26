using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FuncionesMatematicas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 65;
            int numeroDos = 4;

            #region Maximo
            // Calcular el maximo 
            //int numeroMayor = Math.Max(numeroUno, numeroDos); 
            //Console.WriteLine("El numero mayor es {0}", numeroMayor);
            //Console.ReadKey();
            #endregion

            #region Minimo
            // Calcular el minimo 
            //int numeroMenor = Math.Min(numeroUno, numeroDos);
            //Console.WriteLine("El numero menor es {0}", numeroMenor);
            //Console.ReadKey();
            #endregion

            #region Elevado
            // Calcular numero elevado
            //double numeroElevado = Math.Pow(numeroDos,4);
            //Console.WriteLine("La potencia de {0} es {1}", numeroDos, numeroElevado);
            //Console.ReadKey();
            #endregion

            #region Raiz cuadrada
            // Calcular raiz cuadrada
            //double raizCuadrada = Math.Sqrt(numeroDos);
            //Console.WriteLine("La raiz cuadrada de {0} es {1}", numeroDos, raizCuadrada);
            //Console.ReadKey();
            #endregion

            #region Valor absoluto
            // Calcular valor absoluto
            //int valor = -20;
            //int valorAbsoluto = Math.Abs(valor);
            //Console.WriteLine("El valor absoluto de {0} es {1}", valor, valorAbsoluto);
            //Console.ReadKey();
            #endregion

            #region Redondeo
            // Calcular redondeo
            double valorDos = 20.7842;
            int decimales = 2;
            double redondeo = Math.Round(valorDos, decimales);
            Console.WriteLine("El valor redondeado de {0} es {1}", valorDos, redondeo);
            Console.ReadKey();
            #endregion
        }
    }
}

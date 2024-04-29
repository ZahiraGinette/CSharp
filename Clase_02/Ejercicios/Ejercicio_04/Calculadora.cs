using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    /// <summary>
    /// Clase que proporciona métodos para realizar cálculos simples.
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Realiza una operación aritmética entre dos números.
        /// </summary>
        /// <param name="numero1">El primer número de la operación.</param>
        /// <param name="numero2">El segundo número de la operación.</param>
        /// <param name="operador">El operador aritmético a utilizar.</param>
        /// <returns>El resultado de la operación.</returns>
        public static double Calcular(double numero1, double numero2, string operador)
        {
            double retorno = 0;

            switch (operador)
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;

                case "-":
                    retorno = numero1 * numero2;
                    break;

                case "*":
                    retorno = numero1 * numero2;
                    break;

                case "/":
                    if (Validar(numero2))
                    {
                        retorno = numero1 / numero2;
                    }
                    else
                    {
                        retorno = 0;
                    }
                    break;

                default:
                    retorno = 0;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el número proporcionado no sea cero.
        /// </summary>
        /// <param name="numer2">El número a validar.</param>
        /// <returns>True si el número es diferente de cero, False de lo contrario.</returns>
        private static bool Validar(double numero)
        {
            bool retorno = false;

            if (numero != 0)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Muestra el resultado de una operación en la consola.
        /// </summary>
        /// <param name="resultado">El resultado de la operación a mostrar.</param>
        public static void Mostrar(double resultado)
        {
            Console.WriteLine("Resultado = {0}", resultado);
        }
    }
}

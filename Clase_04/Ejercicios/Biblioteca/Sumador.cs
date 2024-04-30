using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un sumador que puede sumar valores numéricos o concatenar cadenas de texto.
    /// </summary>
    public class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la cantidad de sumas.
        /// </summary>
        public int Cantidad
        { 
            get
            {
                return cantidadSumas;
            }
            set
            {
                this.cantidadSumas = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa un sumador con la cantidad de sumas especificada.
        /// </summary>
        /// <param name="cantidadSumas">Cantidad inicial de sumas.</param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Constructor que inicializa un sumador con cantidad de sumas en cero.
        /// </summary>
        public Sumador() : this(0)
        {
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para sumar dos valores numéricos y aumentar la cantidad de sumas.
        /// </summary>
        /// <param name="num1">Primer número a sumar.</param>
        /// <param name="num2">Segundo número a sumar.</param>
        public long Sumar(long num1, long num2)
        {
            cantidadSumas++;
            return num1 + num2;
        }

        /// <summary>
        /// Método para concatenar dos cadenas de texto y aumentar la cantidad de sumas.
        /// </summary>
        /// <param name="str1">Primera cadena a concatenar.</param>
        /// <param name="str2">Segunda cadena a concatenar.</param>
        public string Sumar(string str1, string str2)
        {
            cantidadSumas++;
            return str1 + str2;
        }

        /// <summary>
        /// Conversión explícita que retorna la cantidad de sumas realizadas.
        /// </summary>
        /// <param name="sumador">Sumador del que se desea obtener la cantidad de sumas.</param>
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del operador + para sumar las cantidades de sumas de dos sumadores.
        /// </summary>
        /// <param name="sumador1">Primer sumador.</param>
        /// <param name="sumador2">Segundo sumador.</param>
        /// <returns>La suma de las cantidades de sumas de ambos sumadores.</returns>
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return (int)sumador1 + (int)sumador2;
        }

        /// <summary>
        /// Sobrecarga del operador | para determinar si dos sumadores tienen igual cantidad de sumas.
        /// </summary>
        /// <param name="sumador1">Primer sumador.</param>
        /// <param name="sumador2">Segundo sumador.</param>
        /// <returns>True si ambos sumadores tienen igual cantidad de sumas, False en caso contrario.</returns>
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return (int)sumador1 == (int)sumador2;
        }
        #endregion
    }
}

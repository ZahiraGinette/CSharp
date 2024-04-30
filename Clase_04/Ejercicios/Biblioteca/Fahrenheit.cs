using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una temperatura en Fahrenheit.
    /// </summary>
    public class Fahrenheit
    {
        #region Atributos
        private double valor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Valor de la temperatura en Fahrenheit.
        /// </summary>
        public double Valor { get { return valor; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa una temperatura en Fahrenheit.
        /// </summary>
        /// <param name="valor">Valor de la temperatura en Fahrenheit.</param>
        public Fahrenheit(double valor)
        {
            this.valor = valor;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Convierte una temperatura en Kelvin a Fahrenheit.
        /// </summary>
        /// <param name="k">Temperatura en Kelvin.</param>
        /// <returns>La temperatura convertida a Fahrenheit.</returns>
        public static implicit operator Fahrenheit(Kelvin k)
        {
            double aux = k.Valor * 9 / 5 - 459.67;
            Fahrenheit retorno = new Fahrenheit(aux);
            return retorno;
        }

        /// <summary>
        /// Convierte una temperatura en Celsius a Fahrenheit.
        /// </summary>
        /// <param name="c">Temperatura en Celsius.</param>
        /// <returns>La temperatura convertida a Fahrenheit.</returns>
        public static implicit operator Fahrenheit(Celsius c)
        {
            double aux = c.Valor * 9 / 5 + 32;
            Fahrenheit retorno = new Fahrenheit(aux);
            return retorno;
        }


        /// <summary>
        /// Sobrecarga del operador de suma para Fahrenheit y Kelvin.
        /// </summary>
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            f.valor = f.valor + ((Fahrenheit)k).valor;
            return f;
        }

        /// <summary>
        /// Sobrecarga del operador de suma para Fahrenheit y Celsius.
        /// </summary>
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            f.valor = f.valor + ((Fahrenheit)c).valor;
            return f;
        }

        /// <summary>
        /// Sobrecarga del operador de resta para Fahrenheit y Kelvin.
        /// </summary>
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            f.valor = f.valor - ((Fahrenheit)k).valor;
            return f;
        }

        /// <summary>
        /// Sobrecarga del operador de resta para Fahrenheit y Celsius.
        /// </summary>
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            f.valor = f.valor - ((Fahrenheit)c).valor;
            return f;
        }

        /// <summary>
        /// Sobrecarga del operador de incremento para Fahrenheit.
        /// </summary>
        public static Fahrenheit operator ++(Fahrenheit f)
        {
            f.valor++;
            return f;
        }

        /// <summary>
        /// Sobrecarga del operador de decremento para Fahrenheit.
        /// </summary>
        public static Fahrenheit operator --(Fahrenheit f)
        {
            f.valor--;
            return f;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad para Fahrenheit y Kelvin.
        /// </summary>
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool retorno = false;
            if (f.valor == ((Fahrenheit)k).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad para Fahrenheit y Celsius.
        /// </summary>
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool retorno = false;
            if (f.valor == ((Fahrenheit)c).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para Fahrenheit y Kelvin.
        /// </summary>
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            bool retorno = true;
            if (f.valor == ((Fahrenheit)k).valor)
            {
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para Fahrenheit y Celsius.
        /// </summary>
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            bool retorno = true;
            if (f.valor == ((Fahrenheit)c).valor)
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion
    }
}

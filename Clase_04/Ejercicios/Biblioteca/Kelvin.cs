using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una temperatura en Kelvin.
    /// </summary>
    public class Kelvin
    {
        #region Atributos
        private double valor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Valor de la temperatura en Kelvin.
        /// </summary>
        public double Valor { get { return valor; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa una temperatura en Kelvin.
        /// </summary>
        /// <param name="valor">Valor de la temperatura en Kelvin.</param>
        public Kelvin(double valor)
        {
            this.valor = valor;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Convierte una temperatura en Celsius a Kelvin.
        /// </summary>
        /// <param name="c">Temperatura en Celsius.</param>
        /// <returns>La temperatura convertida a Kelvin.</returns>
        public static implicit operator Kelvin(Celsius c)
        {
            double aux = c.Valor + 273.15;
            Kelvin retorno = new Kelvin(aux);
            return retorno;
        }

        /// <summary>
        /// Convierte una temperatura en Fahrenheit a Kelvin.
        /// </summary>
        /// <param name="f">Temperatura en Fahrenheit.</param>
        /// <returns>La temperatura convertida a Kelvin.</returns>
        public static implicit operator Kelvin(Fahrenheit f)
        {
            double aux = (f.Valor + 459.67) * 5 / 9;
            Kelvin retorno = new Kelvin(aux);
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de suma para Kelvin y Fahrenheit.
        /// </summary>
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            k.valor = k.valor + ((Kelvin)f).valor;
            return k;
        }

        /// <summary>
        /// Sobrecarga del operador de resta para Kelvin y Fahrenheit.
        /// </summary>
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            k.valor = k.valor - ((Kelvin)f).valor;
            return k;
        }

        /// <summary>
        /// Sobrecarga del operador de incremento para Kelvin.
        /// </summary>
        public static Kelvin operator ++(Kelvin k)
        {
            k.valor++;
            return k;
        }

        /// <summary>
        /// Sobrecarga del operador de decremento para Kelvin.
        /// </summary>
        public static Kelvin operator --(Kelvin k)
        {
            k.valor--;
            return k;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad para Kelvin y Fahrenheit.
        /// </summary>
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            bool retorno = false;
            if (k.valor == ((Kelvin)f).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para Kelvin y Fahrenheit.
        /// </summary>
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            bool retorno = true;
            if (k.valor == ((Kelvin)f).valor)
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una temperatura en Celsius.
    /// </summary>
    public class Celsius
    {
        #region Atributos
        private double valor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Valor de la temperatura en Celsius.
        /// </summary>
        public double Valor { get { return valor; } }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa una temperatura en Celsius.
        /// </summary>
        /// <param name="valor">Valor de la temperatura en Celsius.</param>
        public Celsius(double valor)
        {
            this.valor = valor;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Convierte una temperatura en Kelvin a Celsius.
        /// </summary>
        /// <param name="k">Temperatura en Kelvin.</param>
        /// <returns>La temperatura convertida a Celsius.</returns>
        public static implicit operator Celsius(Kelvin k)
        {
            double aux = k.Valor - 273.15;
            Celsius retorno = new Celsius(aux);
            return retorno;
        }

        /// <summary>
        /// Convierte una temperatura en Fahrenheit a Celsius.
        /// </summary>
        /// <param name="f">Temperatura en Fahrenheit.</param>
        /// <returns>La temperatura convertida a Celsius.</returns>
        public static implicit operator Celsius(Fahrenheit f)
        {
            double aux = (f.Valor - 32) * 5 / 9;
            Celsius retorno = new Celsius(aux);
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de suma para Celsius y Fahrenheit.
        /// </summary>
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            c.valor = c.valor + ((Celsius)f).valor;
            return c;
        }

        /// <summary>
        /// Sobrecarga del operador de resta para Celsius y Fahrenheit.
        /// </summary>
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            c.valor = c.valor - ((Celsius)f).valor;
            return c;
        }

        /// <summary>
        /// Sobrecarga del operador de incremento para Celsius.
        /// </summary>
        public static Celsius operator ++(Celsius c)
        {
            c.valor++;
            return c;
        }

        /// <summary>
        /// Sobrecarga del operador de decremento para Celsius.
        /// </summary>
        public static Celsius operator --(Celsius c)
        {
            c.valor--;
            return c;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad para Celsius y Fahrenheit.
        /// </summary>
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool retorno = false;
            if (c.valor == ((Celsius)f).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para Celsius y Fahrenheit.
        /// </summary>
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            bool retorno = true;
            if (c.valor == ((Celsius)f).valor)
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion
    }
}

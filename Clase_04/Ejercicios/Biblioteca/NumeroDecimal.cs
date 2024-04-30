using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un número decimal.
    /// </summary>
    public class NumeroDecimal
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de solo lectura que devuelve el número decimal.
        /// </summary>
        public double Numero
        {
            get
            {
                return numero;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de la clase NumeroDecimal.
        /// </summary>
        /// <param name="numero">El número decimal que se asignará al objeto.</param>
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Convierte un número decimal en un número binario.
        /// </summary>
        /// <param name="numero">El número decimal a convertir.</param>
        /// <returns>Una cadena que representa el número binario equivalente.</returns>
        public string DecimalBinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultDiv = (int)numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resultDiv > 0);
            }

            return valorBinario;
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Convierte explícitamente un número decimal en un objeto NumeroDecimal.
        /// </summary>
        /// <param name="numero">El número decimal a convertir.</param>
        /// <returns>El objeto NumeroDecimal creado a partir del número decimal dado.</returns>
        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        /// <summary>
        /// Convierte explícitamente un objeto NumeroDecimal en un objeto NumeroBinario.
        /// </summary>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a convertir.</param>
        /// <returns>El objeto NumeroBinario equivalente al objeto NumeroDecimal dado.</returns>
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalBinario(numeroDecimal.Numero);
        }

        /// <summary>
        /// Compara si un objeto NumeroDecimal es igual a un objeto NumeroBinario.
        /// </summary>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a comparar.</param>
        /// <param name="numeroBinario">El objeto NumeroBinario a comparar.</param>
        /// <returns>true si los números son iguales, false en caso contrario.</returns>
        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero == ((NumeroDecimal)numeroBinario).Numero;
        }

        /// <summary>
        /// Compara si un objeto NumeroDecimal no es igual a un objeto NumeroBinario.
        /// </summary>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a comparar.</param>
        /// <param name="numeroBinario">El objeto NumeroBinario a comparar.</param>
        /// <returns>true si los números son diferentes, false en caso contrario.</returns>
        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }

        /// <summary>
        /// Realiza la suma de un objeto NumeroDecimal y un objeto NumeroBinario.
        /// </summary>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a sumar.</param>
        /// <param name="numeroBinario">El objeto NumeroBinario a sumar.</param>
        /// <returns>El resultado de la suma en formato decimal.</returns>
        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero + ((NumeroDecimal)numeroBinario).Numero;
        }

        /// <summary>
        /// Realiza la resta de un objeto NumeroDecimal y un objeto NumeroBinario.
        /// </summary>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a restar.</param>
        /// <param name="numeroBinario">El objeto NumeroBinario a restar.</param>
        /// <returns>El resultado de la resta en formato decimal.</returns>
        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.Numero - ((NumeroDecimal)numeroBinario).Numero;
        }
        #endregion
    }
}

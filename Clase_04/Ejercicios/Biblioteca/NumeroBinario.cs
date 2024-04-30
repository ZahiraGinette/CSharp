using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un número binario.
    /// </summary>
    public class NumeroBinario
    {
        #region Atributos
        private string numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de solo lectura que devuelve el número binario.
        /// </summary>
        public string Numero
        {
            get
            {
                return numero;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de la clase NumeroBinario.
        /// </summary>
        /// <param name="numero">El número binario que se asignará al objeto.</param>
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Convierte un número binario en un número decimal.
        /// </summary>
        /// <param name="valorRecibido">El número binario a convertir.</param>
        /// <returns>El número decimal equivalente al número binario dado.</returns>
        public double BinarioDecimal(string valorRecibido)
        {
            double resultado = 0;
            int cantidadCaracteres = valorRecibido.Length;
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
            }

            return resultado;
        }
        #endregion


        #region Sobrecarga
        /// <summary>
        /// Convierte explícitamente una cadena en un objeto NumeroBinario.
        /// </summary>
        /// <param name="numero">La cadena que representa el número binario.</param>
        /// <returns>El objeto NumeroBinario creado a partir de la cadena dada.</returns>
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        /// <summary>
        /// Convierte explícitamente un objeto NumeroBinario en un objeto NumeroDecimal.
        /// </summary>
        /// <param name="numeroBinario">El objeto NumeroBinario a convertir.</param>
        /// <returns>El objeto NumeroDecimal equivalente al objeto NumeroBinario dado.</returns>
        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)numeroBinario.BinarioDecimal(numeroBinario.Numero);
        }

        /// <summary>
        /// Compara si un objeto NumeroBinario es igual a un objeto NumeroDecimal.
        /// </summary>
        /// <param name="numeroBinario">El objeto NumeroBinario a comparar.</param>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a comparar.</param>
        /// <returns>true si los números son iguales, false en caso contrario.</returns>
        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.Numero == ((NumeroBinario)numeroDecimal).Numero;
        }

        /// <summary>
        /// Compara si un objeto NumeroBinario no es igual a un objeto NumeroDecimal.
        /// </summary>
        /// <param name="numeroBinario">El objeto NumeroBinario a comparar.</param>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a comparar.</param>
        /// <returns>true si los números son diferentes, false en caso contrario.</returns>
        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        /// <summary>
        /// Realiza la suma de un objeto NumeroBinario y un objeto NumeroDecimal.
        /// </summary>
        /// <param name="numeroBinario">El objeto NumeroBinario a sumar.</param>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a sumar.</param>
        /// <returns>Una cadena que representa el resultado de la suma en binario.</returns>
        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            //Usamos el método Decimal a Binario para convertir la suma de los dos numero en Decimal
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero + numeroDecimal.Numero);
        }

        /// <summary>
        /// Realiza la resta de un objeto NumeroBinario y un objeto NumeroDecimal.
        /// </summary>
        /// <param name="numeroBinario">El objeto NumeroBinario a restar.</param>
        /// <param name="numeroDecimal">El objeto NumeroDecimal a restar.</param>
        /// <returns>Una cadena que representa el resultado de la resta en binario.</returns>
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            //Usamos el método Decimal a Binario para convertir la resta de los dos numero en Decimal
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero - numeroDecimal.Numero);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    /// <summary>
    /// Representa la moneda Dolar.
    /// </summary>
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene la cantidad de Dolares.
        /// </summary>
        public double Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        /// <summary>
        /// Obtiene la cotización del Dólar.
        /// </summary>
        public static double Cotizacion
        {
            get
            {
                return cotizRespectoDolar;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa la cotización del Dólar.
        /// </summary>
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Dolar con la cantidad especificada.
        /// </summary>
        /// <param name="cantidad">Cantidad de Dolares.</param>
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Dolar con la cantidad y cotización especificadas.
        /// </summary>
        /// <param name="cantidad">Cantidad de Dolares.</param>
        /// <param name="cotizacion">Cotización del Dólar.</param>
        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Convierte una cantidad de Dolares en un objeto de la clase Dolar.
        /// </summary>
        /// <param name="cantidad">Cantidad de Dolares.</param>
        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        /// <summary>
        /// Convierte un objeto de la clase Dolar en un objeto de la clase Euro.
        /// </summary>
        /// <param name="euro">Objeto Dolar a convertir.</param>
        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad * Euro.Cotizacion);
        }

        /// <summary>
        /// Convierte una cantidad de Dólares en un objeto de la clase Peso.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a convertir.</param>
        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.cantidad * Peso.Cotizacion);
        }

        /// <summary>
        /// Compara dos cantidades de Dólares y determina si son iguales.
        /// </summary>
        /// <param name="dolar1">Primer objeto de la clase Dolar a comparar.</param>
        /// <param name="dolar2">Segundo objeto de la clase Dolar a comparar.</param>
        /// <returns>True si las cantidades de Dólares son iguales, False en caso contrario.</returns>
        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return (dolar1.Cantidad == dolar2.Cantidad);
        }

        /// <summary>
        /// Compara dos cantidades de Dólares y determina si son diferentes.
        /// </summary>
        /// <param name="dolar1">Primer objeto de la clase Dolar a comparar.</param>
        /// <param name="dolar2">Segundo objeto de la clase Dolar a comparar.</param>
        /// <returns>True si las cantidades de Dólares son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }

        /// <summary>
        /// Compara una cantidad de Dólares con una cantidad de Euros y determina si son iguales.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <returns>True si las cantidades son iguales, False en caso contrario.</returns>
        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return (dolar.Cantidad == ((Dolar)euro).Cantidad);
        }

        /// <summary>
        /// Compara una cantidad de Dólares con una cantidad de Euros y determina si son diferentes.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <returns>True si las cantidades son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }

        /// <summary>
        /// Compara una cantidad de Dólares con una cantidad de Pesos y determina si son iguales.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <returns>True si las cantidades son iguales, False en caso contrario.</returns>
        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return (dolar.Cantidad == ((Dolar)peso).Cantidad);
        }

        /// <summary>
        /// Compara una cantidad de Dólares con una cantidad de Pesos y determina si son diferentes.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <returns>True si las cantidades son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return !(dolar == peso);
        }

        /// <summary>
        /// Resta una cantidad de Euros a una cantidad de Dólares y devuelve el resultado como un objeto de la clase Dolar.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a restar.</param>
        /// <param name="euro">Cantidad de Euros a restar.</param>
        /// <returns>Resultado de la resta como un objeto de la clase Dolar.</returns>
        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.Cantidad - ((Dolar)euro).Cantidad);
        }

        /// <summary>
        /// Resta una cantidad de Pesos a una cantidad de Dólares y devuelve el resultado como un objeto de la clase Dolar.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a restar.</param>
        /// <param name="peso">Cantidad de Pesos a restar.</param>
        /// <returns>Resultado de la resta como un objeto de la clase Dolar.</returns>
        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            return new Dolar(dolar.Cantidad - ((Dolar)peso).Cantidad);
        }

        /// <summary>
        /// Suma una cantidad de Euros a una cantidad de Dólares y devuelve el resultado como un objeto de la clase Dolar.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a sumar.</param>
        /// <param name="euro">Cantidad de Euros a sumar.</param>
        /// <returns>Resultado de la suma como un objeto de la clase Dolar.</returns>
        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.Cantidad + ((Dolar)euro).Cantidad);
        }

        /// <summary>
        /// Suma una cantidad de Pesos a una cantidad de Dólares y devuelve el resultado como un objeto de la clase Dolar.
        /// </summary>
        /// <param name="dolar">Cantidad de Dólares a sumar.</param>
        /// <param name="peso">Cantidad de Pesos a sumar.</param>
        /// <returns>Resultado de la suma como un objeto de la clase Dolar.</returns>
        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            return new Dolar(dolar.Cantidad + ((Dolar)peso).Cantidad);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    /// <summary>
    /// Representa la moneda Euro.
    /// </summary>
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene la cantidad de Euros.
        /// </summary>
        public double Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        /// <summary>
        /// Obtiene la cotización del Euro respecto al Dólar.
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
        /// Inicializa la cotización del Euro respecto al Dólar.
        /// </summary>
        static Euro()
        {
            cotizRespectoDolar = 1 / 1.07;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Euro con la cantidad especificada.
        /// </summary>
        /// <param name="cantidad">Cantidad de Euros.</param>
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Euro con la cantidad y cotización especificadas.
        /// </summary>
        /// <param name="cantidad">Cantidad de Euros.</param>
        /// <param name="cotizacion">Cotización del Peso respecto al Dólar.</param>
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Convierte una cantidad de Euros en un objeto de la clase Euro.
        /// </summary>
        /// <param name="cantidad">Cantidad de Pesos.</param>
        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        /// <summary>
        /// Convierte un objeto de la clase Euro en un objeto de la clase Dolar.
        /// </summary>
        /// <param name="euro">Objeto Euro a convertir.</param>
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad / Euro.Cotizacion);
        }

        /// <summary>
        /// Convierte una cantidad de Euros en un objeto de la clase Peso.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a convertir.</param>
        /// <returns>Cantidad de Euros convertida a Peso.</returns>
        public static explicit operator Peso(Euro euro)
        {
            //De esta manera reutilizamos las conversiones explicitas 
            return (Peso)((Dolar)euro);
        }

        /// <summary>
        /// Compara dos cantidades de Euros y determina si son iguales.
        /// </summary>
        /// <param name="euro1">Primer objeto de la clase Euro a comparar.</param>
        /// <param name="euro2">Segundo objeto de la clase Euro a comparar.</param>
        /// <returns>True si las cantidades de Euros son iguales, False en caso contrario.</returns>
        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return (euro1.Cantidad == euro2.Cantidad);
        }

        /// <summary>
        /// Compara dos cantidades de Euros y determina si son diferentes.
        /// </summary>
        /// <param name="euro1">Primer objeto de la clase Euro a comparar.</param>
        /// <param name="euro2">Segundo objeto de la clase Euro a comparar.</param>
        /// <returns>True si las cantidades de Euros son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }

        /// <summary>
        /// Compara una cantidad de Euros con una cantidad de Dólares y determina si son iguales.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <returns>True si las cantidades son iguales, False en caso contrario.</returns>
        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return (euro.Cantidad == ((Euro)dolar).Cantidad);
        }

        /// <summary>
        /// Compara una cantidad de Euros con una cantidad de Dólares y determina si son diferentes.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <returns>True si las cantidades son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        /// <summary>
        /// Compara una cantidad de Euros con una cantidad de Pesos y determina si son iguales.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <returns>True si las cantidades son iguales, False en caso contrario.</returns>
        public static bool operator ==(Euro euro, Peso peso)
        {
            return (euro.Cantidad == ((Euro)peso).Cantidad);
        }

        /// <summary>
        /// Compara una cantidad de Euros con una cantidad de Pesos y determina si son diferentes.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <returns>True si las cantidades son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Euro euro, Peso peso)
        {
            return !(euro == peso);
        }

        /// <summary>
        /// Resta una cantidad de Dólares a una cantidad de Euros y devuelve el resultado como un objeto de la clase Euro.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a restar.</param>
        /// <param name="dolar">Cantidad de Dólares a restar.</param>
        /// <returns>Resultado de la resta como un objeto de la clase Euro.</returns>
        public static Euro operator -(Euro euro, Dolar dolar)
        {
            return new Euro(euro.Cantidad - ((Euro)dolar).Cantidad);
        }

        /// <summary>
        /// Resta una cantidad de Pesos a una cantidad de Euros y devuelve el resultado como un objeto de la clase Euro.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a restar.</param>
        /// <param name="peso">Cantidad de Pesos a restar.</param>
        /// <returns>Resultado de la resta como un objeto de la clase Euro.</returns>
        public static Euro operator -(Euro euro, Peso peso)
        {
            return new Euro(euro.Cantidad - ((Euro)peso).Cantidad);
        }

        /// <summary>
        /// Suma una cantidad de Dólares a una cantidad de Euros y devuelve el resultado como un objeto de la clase Euro.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a sumar.</param>
        /// <param name="dolar">Cantidad de Dólares a sumar.</param>
        /// <returns>Resultado de la suma como un objeto de la clase Euro.</returns>
        public static Euro operator +(Euro euro, Dolar dolar)
        {
            return new Euro(euro.Cantidad + ((Euro)dolar).Cantidad);
        }

        /// <summary>
        /// Suma una cantidad de Pesos a una cantidad de Euros y devuelve el resultado como un objeto de la clase Euro.
        /// </summary>
        /// <param name="euro">Cantidad de Euros a sumar.</param>
        /// <param name="peso">Cantidad de Pesos a sumar.</param>
        /// <returns>Resultado de la suma como un objeto de la clase Euro.</returns>
        public static Euro operator +(Euro euro, Peso peso)
        {
            return new Euro(euro.Cantidad + ((Euro)peso).Cantidad);
        }
        #endregion
    }
}

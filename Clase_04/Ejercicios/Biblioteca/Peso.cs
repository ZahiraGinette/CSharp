using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    /// <summary>
    /// Representa la moneda Pesos.
    /// </summary>
    public class Peso
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene la cantidad de Pesos.
        /// </summary>
        public double Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        /// <summary>
        /// Obtiene la cotización del Peso respecto al Dólar.
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
        /// Inicializa la cotización del Peso respecto al Dólar.
        /// </summary>
        static Peso()
        {
            cotizRespectoDolar = 876.64;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Peso con la cantidad especificada.
        /// </summary>
        /// <param name="cantidad">Cantidad de Pesos.</param>
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Peso con la cantidad y cotización especificadas.
        /// </summary>
        /// <param name="cantidad">Cantidad de Pesos.</param>
        /// <param name="cotizacion">Cotización del Peso respecto al Dólar.</param>
        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Convierte una cantidad de Pesos en un objeto de la clase Peso.
        /// </summary>
        /// <param name="cantidad">Cantidad de Pesos.</param>
        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        /// <summary>
        /// Convierte un objeto de la clase Peso en un objeto de la clase Dolar.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a convertir.</param>
        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.cantidad / Peso.Cotizacion);
        }

        /// <summary>
        /// Convierte un objeto de la clase Peso en un objeto de la clase Euro.
        /// </summary>
        /// <param name="peso">Objeto Pesos a convertir.</param>
        public static explicit operator Euro(Peso peso)
        {
            //De esta manera reutilizamos las conversiones explicitas 
            //tomamos el peso, lo convertimos a Dolar y el resultado de este a Euro
            return (Euro)(Dolar)peso;
        }

        /// <summary>
        /// Compara dos cantidades de Pesos y determina si son iguales.
        /// </summary>
        /// <param name="peso1">Primer objeto de la clase Peso a comparar.</param>
        /// <param name="peso2">Segundo objeto de la clase Peso a comparar.</param>
        /// <returns>True si las cantidades de Pesos son iguales, False en caso contrario.</returns>
        public static bool operator ==(Peso peso1, Peso peso2)
        {
            return (peso1.Cantidad == peso2.Cantidad);
        }

        /// <summary>
        /// Compara dos cantidades de Pesos y determina si son diferentes.
        /// </summary>
        /// <param name="peso1">Primer objeto de la clase Peso a comparar.</param>
        /// <param name="peso2">Segundo objeto de la clase Peso a comparar.</param>
        /// <returns>True si las cantidades de Pesos son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Peso peso1, Peso peso2)
        {
            return !(peso1 == peso2);
        }

        /// <summary>
        /// Compara una cantidad de Pesos con una cantidad de Dólares y determina si son iguales.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <returns>True si las cantidades son iguales, False en caso contrario.</returns>
        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return (peso.Cantidad == ((Peso)dolar).Cantidad);
        }

        /// <summary>
        /// Compara una cantidad de Pesos con una cantidad de Dólares y determina si son diferentes.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <param name="dolar">Cantidad de Dólares a comparar.</param>
        /// <returns>True si las cantidades son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(peso == dolar);
        }

        /// <summary>
        /// Compara una cantidad de Pesos con una cantidad de Euros y determina si son iguales.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <returns>True si las cantidades son iguales, False en caso contrario.</returns>
        public static bool operator ==(Peso peso, Euro euro)
        {
            return (peso.Cantidad == ((Peso)euro).Cantidad);
        }

        /// <summary>
        /// Compara una cantidad de Pesos con una cantidad de Euros y determina si son diferentes.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a comparar.</param>
        /// <param name="euro">Cantidad de Euros a comparar.</param>
        /// <returns>True si las cantidades son diferentes, False en caso contrario.</returns>
        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(peso == euro);
        }

        /// <summary>
        /// Resta una cantidad de Dólares a una cantidad de Pesos y devuelve el resultado como un objeto de la clase Peso.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a restar.</param>
        /// <param name="dolar">Cantidad de Dólares a restar.</param>
        /// <returns>Resultado de la resta como un objeto de la clase Peso.</returns>
        public static Peso operator -(Peso peso, Dolar dolar)
        {
            return new Peso(peso.Cantidad - ((Peso)dolar).Cantidad);
        }

        /// <summary>
        /// Resta una cantidad de Euros a una cantidad de Pesos y devuelve el resultado como un objeto de la clase Peso.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a restar.</param>
        /// <param name="euro">Cantidad de Euros a restar.</param>
        /// <returns>Resultado de la resta como un objeto de la clase Peso.</returns>
        public static Peso operator -(Peso peso, Euro euro)
        {
            return new Peso(peso.Cantidad - ((Peso)euro).Cantidad);
        }

        /// <summary>
        /// Suma una cantidad de Dólares a una cantidad de Pesos y devuelve el resultado como un objeto de la clase Peso.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a sumar.</param>
        /// <param name="dolar">Cantidad de Dólares a sumar.</param>
        /// <returns>Resultado de la suma como un objeto de la clase Peso.</returns>
        public static Peso operator +(Peso peso, Dolar dolar)
        {
            return new Peso(peso.Cantidad + ((Peso)dolar).Cantidad);
        }

        /// <summary>
        /// Suma una cantidad de Euros a una cantidad de Pesos y devuelve el resultado como un objeto de la clase Peso.
        /// </summary>
        /// <param name="peso">Cantidad de Pesos a sumar.</param>
        /// <param name="euro">Cantidad de Euros a sumar.</param>
        /// <returns>Resultado de la suma como un objeto de la clase Peso.</returns>
        public static Peso operator +(Peso peso, Euro euro)
        {
            return new Peso(peso.Cantidad + ((Peso)euro).Cantidad);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un cliente una cuenta corriente.
    /// </summary>
    public class Cuenta
    {
        #region Atributos
        private string titular;
        private decimal cantidad;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cuenta.
        /// </summary>
        /// <param name="titular">El titular de la cuenta.</param>
        /// <param name="cantidad">La cantidad inicial de dinero en la cuenta.</param>
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Obtiene el titular de la cuenta.
        /// </summary>
        /// <returns>El titular de la cuenta.</returns>
        public string GetTitular()
        {
            return this.titular;
        }

        /// <summary>
        /// Obtiene la cantidad de dinero en la cuenta.
        /// </summary>
        /// <returns>La cantidad de dinero en la cuenta.</returns>
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retorna una cadena de texto con los datos de la cuenta.
        /// </summary>
        /// <returns>Una cadena de texto con el titular y la cantidad de dinero en la cuenta.</returns>
        public string Mostrar()
        {
            return $"Titular: {this.titular}, Cantidad: ${this.cantidad}";
        }

        /// <summary>
        /// Deposita una cantidad de dinero en la cuenta.
        /// </summary>
        /// <param name="monto">La cantidad de dinero a depositar.</param>
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
                Console.WriteLine($"Se ha depositado {monto} a la cuenta. Saldo actual: ${this.cantidad}");
            }
        }

        /// <summary>
        /// Retira una cantidad de dinero de la cuenta.
        /// </summary>
        /// <param name="monto">La cantidad de dinero a retirar.</param>
        public void Retirar(decimal monto)
        {
            if (monto > 0 && this.cantidad > 0)
            {
                this.cantidad -= monto;
                Console.WriteLine($"Se ha retirado {monto} de la cuenta. Saldo actual: ${this.cantidad}");
            }
        }
        #endregion
    }
}

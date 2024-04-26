using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Comentarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        // Comentario de una sola linea

        /* 
           Comentario
           de varias
           lineas
            otro comentario
         */

        // Para generar el comentario de XML se debe agregar /// 

        #region "Variables"

        #endregion

        #region "Metodos"

        //

        #endregion

        #region "Nombre de nuestro region"

        /// <summary>
        /// Cotiza la venta de un monto de dolares dado, retornado el costo en pesos
        /// </summary>
        /// <param name="montoDolaresAVender">Cantidad de dolares que se desean vender</param>
        /// <returns>Costo en pesos de la venta.</returns>
        public static decimal CotizarVentaDolares(decimal montoDolaresAVender)
        {
            decimal costoEnPesos = montoDolaresAVender * pesosPorDolarVendido;

            return costoEnPesos;
        }

        /// <summary>
        /// Precio del dolar vendido
        /// </summary>
        private const decimal pesosPorDolarVendido = 950.75M;

        #endregion
    }
}

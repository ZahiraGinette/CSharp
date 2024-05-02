using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Atributos
        private short cilindrada;
        #endregion

        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return cilindrada;
            }
            set
            {
                cilindrada = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de la clase MotoCross con el número de la moto y la escudería especificados.
        /// </summary>
        /// <param name="numero">El número de la moto.</param>
        /// <param name="escuderia">La escudería a la que pertenece a la moto.</param>
        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {
        }

        /// <summary>
        /// Crea una nueva instancia de la clase MotoCross con el número de auto, la escudería y los caballos de fuerza especificados.
        /// </summary>
        /// <param name="numero">El número de la moto.</param>
        /// <param name="escuderia">La escudería a la que pertenece a la moto.</param>
        /// <param name="cilindrada">Los cilindros pertenece a la moto.</param>
        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos de un Formula 1.
        /// </summary>
        /// <returns>Una cadena que representa los datos del Formula 1.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {Cilindrada}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(MotoCross moto1, MotoCross moto2)
        {
            return moto1 == moto2 && moto1.cilindrada == moto2.cilindrada;
        }

        public static bool operator !=(MotoCross moto1, MotoCross moto2)
        {
            return !(moto1 == moto2);
        }
        #endregion
    }
}

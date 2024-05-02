using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        #region Atributos
        private short cantidadCombustible;
        private bool enCompotencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece la cantidad de combustible del automóvil.
        /// </summary>
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        /// <summary>
        /// Obtiene o establece si el automóvil está en competencia.
        /// </summary>
        public bool EnCompetencia
        {
            get { return enCompotencia; }
            set { enCompotencia = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de vueltas restantes del automóvil.
        /// </summary>
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        /// <summary>
        /// Obtiene o establece la escuderia automóvil.
        /// </summary>
        public string Escuderia
        {
            get { return escuderia; }
            set { escuderia = value; }
        }

        /// <summary>
        /// Obtiene o establece el numero automóvil.
        /// </summary>
        public short Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de la clase VehiculoDeCarrera con el número de auto y la escudería especificados.
        /// </summary>
        /// <param name="numero">El número del auto.</param>
        /// <param name="escuderia">La escudería a la que pertenece el auto.</param>
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompotencia = false;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos del automóvil.
        /// </summary>
        /// <returns>Una cadena que representa los datos del automóvil.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nNumero de auto: {numero}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"En competencia: {enCompotencia}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarda de operaciones
        public static bool operator ==(VehiculoDeCarrera vehiculoDeCarrera1, VehiculoDeCarrera vehiculoDeCarrera2)
        {
            return vehiculoDeCarrera1.Numero == vehiculoDeCarrera2.Numero && vehiculoDeCarrera1.Escuderia == vehiculoDeCarrera2.Escuderia;
        }

        public static bool operator !=(VehiculoDeCarrera vehiculoDeCarrera1, VehiculoDeCarrera vehiculoDeCarrera2)
        {
            return !(vehiculoDeCarrera1 == vehiculoDeCarrera2);
        }
        #endregion
    }
}

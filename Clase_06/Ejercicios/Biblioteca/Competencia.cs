using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una competencia de autos de Fórmula 1.
    /// </summary>
    public class Competencia
    {
        #region Atributos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private ETipoCompetencia tipo;
        #endregion

        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return cantidadCompetidores;
            }
            set
            {
                cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return cantidadVueltas;
            }
            set
            {
                cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this [int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public ETipoCompetencia Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado para evitar instanciación sin parámetros.
        /// </summary>
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Competencia con la cantidad de competidores y la cantidad de vueltas especificadas.
        /// </summary>
        /// <param name="cantidadCompetidores">La cantidad máxima de competidores en la competencia.</param>
        /// <param name="cantidadVueltas">La cantidad de vueltas de la competencia.</param>
        /// <param name="tipo">Tipo de competencia.</param>
        public Competencia(short cantidadCompetidores, short cantidadVueltas, ETipoCompetencia tipo)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos de la competencia y de todos los competidores.
        /// </summary>
        /// <returns>Una cadena que representa los datos de la competencia y de todos los competidores.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de vueltas en la competencia: {cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");

            foreach (VehiculoDeCarrera vehiculo in competidores)
            {
                if(vehiculo.GetType() == typeof(AutoF1))
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                else 
                    sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
            }

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator == (Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool resultado = false;

            //Evualamos si el vehiculo a comprar con la competencia, es del mismo tipo y por otro lado evaluamos que este vehiculo se encuentre en la competencia
            //Retornamos true si el vehiculo pertenece a la competencia o bien si el vehiculo difiere con el tipo de competencia
            if((competencia.Tipo == ETipoCompetencia.F1 && vehiculo.GetType() == typeof(AutoF1)) ||
                (competencia.Tipo == ETipoCompetencia.MotoCross && vehiculo.GetType() == typeof(MotoCross)))
            {
                if (competencia.competidores.Count > 0)
                {
                    if (competencia.competidores.Contains(vehiculo))
                    {
                        resultado = true;
                    }
                }
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }

        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            Random combustible = new Random();
            bool resultado = false;

            if (competencia.competidores.Count < competencia.cantidadCompetidores && competencia != vehiculo)
            {
                vehiculo.EnCompetencia = true;
                vehiculo.VueltasRestantes = competencia.cantidadVueltas;
                vehiculo.CantidadCombustible = (short)combustible.Next(15, 100);
                competencia.competidores.Add(vehiculo);
                resultado = true;
            }

            return resultado;
        }

        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool resultado = false;

            if(competencia == vehiculo)
            {
                competencia.competidores.Remove(vehiculo);
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {
        #region Atributos
        private DateTime fechaNacimiento;
        #endregion

        #region Propiedades
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }
        #endregion

        #region Constructores
        public DirectorTecnico(int dni, string nombre) 
            : base(dni, nombre)
        {

        }

        public DirectorTecnico(int dni, string nombre, DateTime fechaNacimiento)
            : this(dni, nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una cadena que representa los datos del director técnico.
        /// </summary>
        /// <returns>Una cadena que representa los datos del director técnico.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento}");

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Comprueba si dos directores tienen el mismo nombre y fecha de nacimiento.
        /// </summary>
        /// <param name="director1">El primer director a comparar.</param>
        /// <param name="director2">El segundo director a comparar.</param>
        /// <returns>True si los directores tienen el mismo nombre y fecha de nacimiento, de lo contrario, False.</returns>
        public static bool operator ==(DirectorTecnico director1, DirectorTecnico director2)
        {
            return director1.fechaNacimiento == director2.fechaNacimiento && director1.Nombre == director2.Nombre;
        }

        /// <summary>
        /// Comprueba si dos directores tienen el nombre y fecha de nacimiento diferentes.
        /// </summary>
        /// <param name="director1">El primer director a comparar.</param>
        /// <param name="director2">El segundo director a comparar.</param>
        /// <returns>True si los directores tienen diferentes nombres y fecha de nacimiento, de lo contrario, False.</returns>
        public static bool operator !=(DirectorTecnico director1, DirectorTecnico director2)
        {
            return !(director1 == director2);
        }
        #endregion
    }
}

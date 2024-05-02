using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una persona.
    /// </summary>
    public class Persona
    {
        #region Atributos

        private int dni;
        private string nombre;

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el DNI de la persona.
        /// </summary>
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Persona que recibe el DNI como parámetro.
        /// </summary>
        /// <param name="dni">DNI de la persona.</param>
        public Persona(int dni)
        {
            this.dni = dni;
        }

        /// <summary>
        /// Constructor de la clase Persona que recibe el DNI y el nombre como parámetros.
        /// </summary>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        public Persona(int dni, string nombre)
            : this(dni)
        {
            this.nombre = nombre;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que muestra los datos de la persona en formato de texto.
        /// </summary>
        /// <returns>Los datos de la persona en formato de texto.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");

            return sb.ToString();
        }

        #endregion
    }
}

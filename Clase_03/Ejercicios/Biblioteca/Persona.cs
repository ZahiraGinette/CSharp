using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa a una persona con nombre, fecha de nacimiento y DNI.
    /// </summary>
    public class Persona
    {
        #region Atributos
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="fechaDeNacimiento">La fecha de nacimiento de la persona.</param>
        /// <param name="dni">El DNI de la persona.</param>
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Calcula la edad de la persona basándose en la fecha de nacimiento.
        /// </summary>
        /// <returns>La edad actual de la persona.</returns>
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            if (fechaDeNacimiento > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaDeNacimiento.Year;

                if (fechaDeNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }

        /// <summary>
        /// Retorna una cadena de texto con los datos de la persona, incluyendo la edad actual.
        /// </summary>
        /// <returns>Una cadena de texto con el nombre, fecha de nacimiento, DNI y edad de la persona.</returns>
        public string Mostrar()
        {
            int edad = CalcularEdad();
            return $"Nombre: {nombre}, Fecha de nacimiento: {fechaDeNacimiento.ToShortDateString()}, DNI: {dni}, Edad: {edad} años";
        }

        /// <summary>
        /// Determina si la persona es mayor de edad.
        /// </summary>
        /// <returns>"Es mayor de edad" si la persona es mayor de 18 años, de lo contrario, "Es menor".</returns>
        public string EsMayorDeEdad()
        {
            if (CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }
        #endregion
    }
}

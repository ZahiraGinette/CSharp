using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa una mascota de un cliente de la veterinaria.
    /// </summary>
    public class Mascota
    {
        #region Atributos
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string vacuna;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Mascota.
        /// </summary>
        /// <param name="especie">Especie de la mascota.</param>
        /// <param name="nombre">Nombre de la mascota.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la mascota.</param>
        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Especie de la mascota.
        /// </summary>
        public string Especie { get { return especie; } set { especie = value; } }

        /// <summary>
        /// Nombre de la mascota.
        /// </summary>
        public string Nombre { get { return nombre; } set { nombre = value; } }

        /// <summary>
        /// Fecha de nacimiento de la mascota.
        /// </summary>
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }

        /// <summary>
        /// Vacuna aplicada a la mascota.
        /// </summary>
        public string Vacuna { get { return vacuna; } set { vacuna = value; } }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve una representación en formato string de la mascota y su historial de vacunación.
        /// </summary>
        /// <returns>Información de la mascota y su historial de vacunación.</returns>
        public string Mostrar()
        {
            string infoMascota = $"Nombre: {Nombre}\nEspecie: {Especie}\nFecha de nacimiento: {FechaNacimiento.ToShortDateString()}";
            string infoVacuna = !string.IsNullOrEmpty(Vacuna) ? $"\nVacuna: {Vacuna}" : "\nNo tiene vacunas aplicadas.";
            return infoMascota + infoVacuna;
        }
        #endregion
    }
}

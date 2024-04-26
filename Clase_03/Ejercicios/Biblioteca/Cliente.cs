using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un cliente de la veterinaria.
    /// </summary>
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string domicilio;
        private int telefono;
        private Mascota mascota;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cliente.
        /// </summary>
        /// <param name="nombre">Nombre del cliente.</param>
        /// <param name="apellido">Apellido del cliente.</param>
        /// <param name="domicilio">Domicilio del cliente.</param>
        /// <param name="telefono">Teléfono del cliente.</param>
        public Cliente(string nombre, string apellido, string domicilio, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
        #endregion

        #region Propiedades
        // <summary>
        /// Nombre del cliente.
        /// </summary>
        public string Nombre { get { return nombre; } set { nombre = value; } }

        // <summary>
        /// Apellido del cliente.
        /// </summary>
        public string Apellido { get { return apellido; } set { apellido = value; } }

        /// <summary>
        /// Domicilio del cliente.
        /// </summary>
        public string Domicilio { get { return domicilio; } set { domicilio = value; } }

        /// <summary>
        /// Teléfono del cliente.
        /// </summary>
        public int Telefono { get { return telefono; } set { telefono = value; } }

        /// <summary>
        /// Mascota asociada al cliente.
        /// </summary>
        public Mascota Mascota { get { return mascota; } set { mascota = value; } }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve la información del cliente y su mascota en formato string.
        /// </summary>
        /// <returns>Información del cliente y su mascota.</returns>
        public override string ToString()
        {
            string infoCliente = $"Nombre: {Nombre} Apellido:{Apellido}\nDomicilio: {Domicilio}\nTeléfono: {Telefono}";
            string infoMascota = Mascota != null ? $"\nMascota: \n{Mascota.Mostrar()}" : "\nNo tiene mascota asociada.";
            return infoCliente + infoMascota;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa un grupo de mascotas.
    /// </summary>
    public class Grupo
    {
        #region Atributos
        private List<Mascota> _manada;
        private string _nombre;
        private static ETipoManada _tipo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el tipo de la manada.
        /// </summary>
        public ETipoManada Tipo
        {
            set { _tipo = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor estático que inicializa el tipo de manada como Unica.
        /// </summary>
        static Grupo()
        {
            _tipo = ETipoManada.Unica;
        }

        /// <summary>
        /// Constructor privado que inicializa una nueva instancia de la clase Grupo.
        /// </summary>
        private Grupo()
        {
            _manada = new List<Mascota>();
        }

        /// <summary>
        /// Constructor que inicializa una nueva instancia de la clase Grupo con un nombre.
        /// </summary>
        /// <param name="nombre">Nombre del grupo.</param>
        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        /// <summary>
        /// Constructor que inicializa una nueva instancia de la clase Grupo con un nombre y un tipo de manada.
        /// </summary>
        /// <param name="nombre">Nombre del grupo.</param>
        /// <param name="tipo">Tipo de la manada.</param>
        public Grupo(string nombre, ETipoManada tipo)
            : this(nombre)
        {
            _tipo = tipo;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador de igualdad para determinar si una mascota está en el grupo.
        /// </summary>
        public static bool operator ==(Grupo g, Mascota m)
        {
            return g._manada.Contains(m);
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para determinar si una mascota no está en el grupo.
        /// </summary>
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        /// <summary>
        /// Sobrecarga del operador de adición para agregar una mascota al grupo.
        /// </summary>
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
                g._manada.Add(m);
            else
                Console.WriteLine("Ya se encuentra la mascota en la manada.");

            return g;
        }

        /// <summary>
        /// Sobrecarga del operador de sustracción para quitar una mascota del grupo.
        /// </summary>
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
                g._manada.Remove(m);
            else
                Console.WriteLine("No se encuentra la mascota en la manada.");

            return g;
        }

        /// <summary>
        /// Conversión implícita de un grupo a una cadena de caracteres que representa la información del grupo y sus integrantes.
        /// </summary>
        public static implicit operator string(Grupo grupo)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"*** MANADA: {grupo._nombre} - TIPO: {_tipo} - INTEGRANTES: {grupo._manada.Count} ***");

            foreach (Mascota mascota in grupo._manada)
            {
                if (mascota is Gato gato)
                {
                    stringBuilder.AppendLine("=============== Gato ==================");
                    stringBuilder.AppendLine(gato.ToString());
                }
                else if (mascota is Perro perro)
                {
                    stringBuilder.AppendLine("=============== Perro ==================");
                    stringBuilder.AppendLine(perro.ToString());
                }
            }
            stringBuilder.AppendLine("***************************************************");
            return stringBuilder.ToString();
        }
        #endregion
    }
}

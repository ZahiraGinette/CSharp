using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa a un perro, una subclase de Mascota.
    /// </summary>
    public class Perro : Mascota
    {
        #region Atributos
        private int _edad;
        private bool _esAlfa;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Perro.
        /// </summary>
        /// <param name="nombre">Nombre del perro.</param>
        /// <param name="raza">Raza del perro.</param>
        /// <param name="edad">Edad del perro.</param>
        /// <param name="esAlfa">Indica si el perro es el alfa de la manada.</param>
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            _edad = edad;
            _esAlfa = esAlfa;
        }

        /// <summary>
        /// Constructor de la clase Perro con valores por defecto para la edad y si es alfa.
        /// </summary>
        /// <param name="nombre">Nombre del perro.</param>
        /// <param name="raza">Raza del perro.</param>
        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false)
        {

        }

        #endregion

        #region Métodos
        /// <summary>
        /// Genera una ficha del perro con sus datos.
        /// </summary>
        /// <returns>Ficha del perro.</returns>
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.DatosCompletos());
            sb.AppendLine($"Edad: {_edad}");

            if (_esAlfa)
                sb.AppendLine("Alfa de la manada");
 

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador de igualdad para comparar perros.
        /// </summary>
        public static bool operator ==(Perro p1, Perro p2)
        {
            return p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para comparar perros.
        /// </summary>
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Conversión explícita de un perro a su edad.
        /// </summary>
        public static explicit operator int(Perro perro)
        {
            return perro._edad;
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Devuelve una representación de cadena de la ficha del perro.
        /// </summary>
        public override string ToString()
        {
            return Ficha();
        }

        /// <summary>
        /// Determina si el objeto dado es igual al perro actual.
        /// </summary>
        public override bool Equals(object obj)
        {   
            return obj is Perro perro && perro == this;
        }

        /// <summary>
        /// Obtiene el código hash del nombre del perro.
        /// </summary>
        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
        #endregion
    }
}

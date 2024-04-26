using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa a un estudiante con nombre, apellido, legajo y notas de exámenes.
    /// </summary>
    public class Estudiante
    {
        #region Atributos
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private Random random;
        #endregion

        #region Construtores
        /// <summary>
        /// Constructor de instancia que inicializa los atributos nombre, apellido y legajo.
        /// </summary>
        /// <param name="nombre">El nombre del estudiante.</param>
        /// <param name="apellido">El apellido del estudiante.</param>
        /// <param name="legajo">El número de legajo del estudiante.</param>
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.random = new Random();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Cambia el valor del atributo notaPrimerParcial.
        /// </summary>
        /// <param name="nota">La nueva nota del primer parcial.</param>
        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        /// <summary>
        /// Cambia el valor del atributo notaSegundoParcial.
        /// </summary>
        /// <param name="nota">La nueva nota del segundo parcial.</param>
        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        /// <summary>
        /// Calcula el promedio de las dos notas.
        /// </summary>
        /// <returns>El promedio de las dos notas.</returns>
        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2d;
        }

        /// <summary>
        /// Calcula la nota final del estudiante.
        /// </summary>
        /// <returns>La nota final del estudiante.</returns>
        public int CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 10);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Genera una cadena de texto con todos los datos del estudiante.
        /// </summary>
        /// <returns>Una cadena de texto con los datos del estudiante.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }
        #endregion
    }
}

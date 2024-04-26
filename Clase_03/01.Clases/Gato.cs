using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gato
    {
        #region "Atributos"
        private DateTime fechaNacimiento;
        private string nombre;
        private string raza;
        private string tipoPelo;
        private int edad;

        #endregion

        #region "Metodos"

        /// <summary>
        /// Mostrara el alimento que se alimenta el gato.
        /// </summary>
        /// <param name="alimento">Alimento del gato</param>
        /// <returns>Mensaje de lo que esta comeindo el gato.</returns>
        public string Comer(string alimento)
        {
            StringBuilder stringBuilder = new StringBuilder();
            return stringBuilder.AppendFormat("El gato se alimenta de {0}.", alimento).ToString();
        }

       /// <summary>
       /// Mostrara un mensaje si el gato esta ronroneando
       /// </summary>
        public void Ronronear()
        {
            Console.WriteLine("El gato esta ronroneando!");
        }


       /// <summary>
       /// El gato prepara la dominacion mundial
       /// </summary>
        public void PlanearDominacionMundial()
        {
            Console.WriteLine("El dominio total del mundo.");
        }

        /// <summary>
        /// Se mostrara un mensaje indicando la edad del gato.
        /// </summary>
        public void MostrarEdad()
        {
            Console.WriteLine($"La edad del gato es {this.edad}");
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase derivada que implementa la sobrescritura de métodos.
    /// </summary>
    public class SobreSobrescrito : Sobrescrito
    {
        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve el valor de miAtributo.
        /// </summary>
        public override string MiPropiedad
        {
            get
            {
                return miAtributo;
            }
            set
            {
                miAtributo = value;
            }
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Implementación del método abstracto MiMetodo.
        /// </summary>
        /// <returns>El valor de la propiedad MiPropiedad.</returns>
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
        #endregion
    }
}

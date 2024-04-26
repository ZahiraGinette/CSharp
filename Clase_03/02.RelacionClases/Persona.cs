using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionClases
{
    public class Persona
    {
        #region "Atributos"
        private Mascota mascota;
        private int edad;

        #endregion

        #region "Metodos"

        public void LlevarAlVeterinario()
        {
            this.mascota = new Mascota();   
            this.edad = 25;
        }

        #endregion
    }
}

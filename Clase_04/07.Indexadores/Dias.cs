using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Dias
    {
        string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        string[] diasDos = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        public string this[int index]
        {
            get
            {
                return dias[index];
            }
            set
            {
                dias[index] = value;
            }
        }


        public string[] DiasDos
        {
            get
            {
                return this.diasDos;
            }
        }

    }
}

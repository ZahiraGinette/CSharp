using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eventos_y_delegados_consola
{
    public class InfoTiempoEventArgs : EventArgs
    {

        private DateTime _tiempoActual;

        public DateTime TiempoActual
        {
            get { return _tiempoActual; }
            set { _tiempoActual = value; }
        } 
        public InfoTiempoEventArgs(DateTime tiempoActual)
        {
            _tiempoActual = tiempoActual;
        }
     
    }
}

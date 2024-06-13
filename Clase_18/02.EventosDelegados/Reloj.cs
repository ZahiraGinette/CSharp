using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Eventos_y_delegados
{
    public class Reloj
    {
        public delegate void NotificarCambioTiempoHandler(object sender, InfoTiempoEventArgs e);

        public event NotificarCambioTiempoHandler SegundoCambio;

    }
}

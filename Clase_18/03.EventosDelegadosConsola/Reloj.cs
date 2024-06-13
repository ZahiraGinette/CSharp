using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Eventos_y_delegados_consola
{
    public class Reloj
    {
        public delegate void NotificarCambioTiempo(object sender, InfoTiempoEventArgs e);

        public event NotificarCambioTiempo SegundoCambio;
        public void ActualizarTiempo()
        {
            DateTime tiempoActual = DateTime.Now;
            InfoTiempoEventArgs args = new InfoTiempoEventArgs(tiempoActual);

            // Verificar si hay suscriptores antes de invocar el evento
            if (SegundoCambio != null)
            {
                SegundoCambio.Invoke(this, args);
            }
        }


        public void MostrarCambioTiempo(object reloj, InfoTiempoEventArgs e)
        {
            Console.WriteLine($"{e.TiempoActual.Hour}-{e.TiempoActual.Minute}-{e.TiempoActual.Second}");
             
        }
    }
}

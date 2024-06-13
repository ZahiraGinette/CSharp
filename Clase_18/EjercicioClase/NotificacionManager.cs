using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class NotificacionManager
    {
        private readonly INotificacionService _notificacionService;

        public NotificacionManager(INotificacionService notificacionService)
        {
            _notificacionService = notificacionService;
            _notificacionService.NotificacionRecibida += ManejarNotificacion;
        }

        private void ManejarNotificacion(object sender, NotificacionEventArgs e)
        {
            Console.WriteLine($"Notificación recibida: {e.Mensaje}");
        }

        public void EnviarNotificacion(string mensaje)
        {
            _notificacionService.Notificar(mensaje);
        }
    }
}

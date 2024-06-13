using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class EmailNotificacionService : INotificacionService
    {
        public event EventHandler<NotificacionEventArgs> NotificacionRecibida;

        public void Notificar(string mensaje)
        {
            NotificacionRecibida.Invoke(this, new NotificacionEventArgs($"Correo Electrónico: {mensaje}"));
        }
    }
}

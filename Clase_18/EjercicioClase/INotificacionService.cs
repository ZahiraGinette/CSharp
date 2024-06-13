using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public interface INotificacionService
    {
        // El event handler 
        event EventHandler<NotificacionEventArgs> NotificacionRecibida;
        void Notificar(string mensaje);
    }
}

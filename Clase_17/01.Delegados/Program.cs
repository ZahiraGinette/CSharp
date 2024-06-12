using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Delegados
{ 
    public class Program
    {
        // VISIBILIDAD + DELEGATE + RETORNO + NOMBRE + (PARAMETROS OPCIONALES)
        // Se declara delegado
        public delegate void DelegadoNotificacion(string str,string otroNombre);
        public delegate void DelegadoNotificacionDos(string str);

        static void Notificar(string nombre, string otroNombre)
        {
            Console.WriteLine($"Se recibió una notificacion para: {nombre} - {otroNombre}"); 
        }

        static void NotificarDos(string nombre)
        {
            Console.WriteLine($"Este es mi segundo mensaje : {nombre}");
        }

        static void Main(string[] args)
        {
            // Se instancia el delegado, donde le pasamos como parametro un METODO
            DelegadoNotificacion delegado = new DelegadoNotificacion(Notificar);
            DelegadoNotificacionDos delegadoDos = new DelegadoNotificacionDos(NotificarDos);

            delegado("Juan Perez", "Roberto");

            delegadoDos("Veronica Bustos");

            Console.ReadKey();
        }
    }
}

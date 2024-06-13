using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Eventos_y_delegados_consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Reloj reloj = new Reloj();

             reloj.SegundoCambio += reloj.MostrarCambioTiempo; // Suscribir al evento

             // Simular una actualización de tiempo invocando el evento
             reloj.ActualizarTiempo();*/


            RelojDos reloj = new RelojDos();
            Observador observador = new Observador(reloj);

            // Iniciar el reloj
            reloj.Iniciar();
        } 
    }

    public delegate void SegundoTranscurridoEventHandler(object sender, EventArgs e);

    public class RelojDos
    {
        // Declaración del evento
        public event SegundoTranscurridoEventHandler SegundoTranscurrido;

        // Método para iniciar el reloj y generar eventos cada segundo
        public void Iniciar()
        {
            while (true)
            {
                OnSegundoTranscurrido(); // Generar evento
            }
        }

        // Método para invocar el evento
        protected virtual void OnSegundoTranscurrido()
        {
            SegundoTranscurrido.Invoke(this, EventArgs.Empty);
        }
    }

    // Clase que se suscribe al evento del reloj
    public class Observador
    {
        // Constructor
        public Observador(RelojDos reloj)
        {
            reloj.SegundoTranscurrido += Reloj_SegundoTranscurrido;
        }

        // Método que se ejecuta cuando ocurre el evento
        private void Reloj_SegundoTranscurrido(object sender, EventArgs e)
        {
            Console.WriteLine("¡Ha transcurrido un segundo!");
        }
    }
}

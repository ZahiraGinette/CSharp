using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interfaz_implementacion
{
    public class Cuervo: IMensaje, IEncriptado
    {
        // Forma implicita
        public string EnviarMensaje()
        {
            return "Hace mucho frio!";
        }

        // Forma explicita
        string IEncriptado.EnviarMensaje() // Si le agreamos public nos arroja error
        {
            return "Jon Snow es el verdadero rey";
        }

    }
}

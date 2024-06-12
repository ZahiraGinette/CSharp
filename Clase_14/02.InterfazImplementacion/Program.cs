using System;

namespace _02.Interfaz_implementacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuervo cuervo = new Cuervo();

            // Implicita
            Console.WriteLine(cuervo.EnviarMensaje());

            // Explicita
            Console.WriteLine(((IEncriptado)cuervo).EnviarMensaje());

        }
    }
}

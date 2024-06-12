using System;
using System.Collections.Generic;

namespace _03.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listado = new List<string>();

            Dictionary<int, string> otroLisado = new Dictionary<int, string>();

            // Uso simple
            Mensaje<string> mensajeString = new Mensaje<string>();

            Mensaje<float> mensajeFloat = new Mensaje<float>();

            // Uso mas complejo
            Mensajero<string, int> mensajeroUno = new Mensajero<string, int>();

            Mensajero<string, double> mensajeroDos = new Mensajero<string, double>();

        }
    }
}
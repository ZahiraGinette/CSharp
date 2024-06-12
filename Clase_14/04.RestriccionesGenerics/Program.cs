using System;

namespace _04.Restricciones_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo<int> ejemploInt = new Ejemplo<int>();
            int valor = ejemploInt.ValorPorDefecto();
            Console.WriteLine(valor);

            EjemploDos<string> ejemploString = new EjemploDos<string>();
            ejemploString.Metodo("Hola Mundo");

            EjemploTres<int> ejemploIntDos = new EjemploTres<int>();
            ejemploIntDos.Metodo(10);

            EjemploCuatro<DateTime> ejemploDateTime = new EjemploCuatro<DateTime>();
            DateTime fecha = ejemploDateTime.CrearInstancia();
            Console.WriteLine(fecha);

            EjemploCinco<ClaseDerivada> ejemploCinco = new EjemploCinco<ClaseDerivada>();
            ejemploCinco.MetodoGenerico(new ClaseDerivada());

            EjemploSeis<Clase> ejemploSeis = new EjemploSeis<Clase>();
            ejemploSeis.MetodoGenerico(new Clase());

            EjemploSiete<ClaseDerivada, ClaseBase> ejemploSiete = new EjemploSiete<ClaseDerivada, ClaseBase>();
            ejemploSiete.Metodo(new ClaseDerivada());
        }
    }
}

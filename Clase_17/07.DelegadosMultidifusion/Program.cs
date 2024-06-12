using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07.Delegados_Multidifusion
{
    // Lo creamos fuera de la clase
    public delegate void Delegado(string cadena);

    public class Clase
    {
        public void MetodoUno(string cadena)
        {
            Console.WriteLine("Este es mi primer metodo" + cadena);
        }
        public void MetodoDos(string cadena)
        {
            Console.WriteLine("Este es mi segundo metodo" + cadena);
        }
        public void MetodoTres(string cadena)
        {
            Console.WriteLine(cadena);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Se instancia el objeto que contiene los métodos que encapsulará el delegado.
            Clase objeto = new Clase();

            // Se instancia dos delegados.
            Delegado delegadoUno = objeto.MetodoUno;
            Delegado delegadoDos = objeto.MetodoDos;

            Delegado delegadoMultidifusion = delegadoDos;
            delegadoMultidifusion("Mensaje");

            delegadoMultidifusion += delegadoUno;
            delegadoMultidifusion("Mensaje");
 
            // Saber la cantidad de metodos que tiene mi delegado?

            delegadoMultidifusion -= objeto.MetodoTres;
            delegadoMultidifusion("Mensaje");

            // Aca agregamos uno
            //delegadoMultidifusion += objeto.MetodoTres;

            delegadoMultidifusion("Mensaje");
            Console.ReadKey();  
        }
    }
}

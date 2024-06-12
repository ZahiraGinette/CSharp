using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Restricciones_generics
{
    public class Ejemplo<T> where T : struct
    {
        public T ValorPorDefecto()
        {
            return default(T); // Devuelve el valor predeterminado para el tipo T
        }
    }

    public class EjemploDos<T> where T : class
    {
        public void Metodo(T objeto)
        {
            Console.WriteLine(objeto.ToString()); // Ejemplo de uso de un método de clase
        }
    }

    public class EjemploTres<T> where T : unmanaged
    {   
        public void Metodo(T valor)
        {
            Console.WriteLine(valor.ToString()); // Ejemplo de uso de un método de struct
        }
    }

    public class EjemploCuatro<T> where T : new()
    {
        public T CrearInstancia()
        {
            return new T(); // Crea una nueva instancia de T
        }
    }



    public class ClaseBase
    {
        public void Metodo()
        {
            Console.WriteLine("Método de la clase base");
        }
    }

    public class EjemploCinco<T> where T : ClaseBase
    {
        public void MetodoGenerico(T objeto)
        {
            objeto.Metodo(); // Llamada al método de la clase base
        }
    }

    class ClaseDerivada : ClaseBase
    {
        // Puedes añadir métodos y propiedades adicionales aquí
    }


    public interface IInterfaz
    {
        void Metodo();
    }

    public class EjemploSeis<T> where T : IInterfaz
    {
        public void MetodoGenerico(T objeto)
        {
            objeto.Metodo(); // Llamada al método de la interfaz
        }
    }

    class Clase : IInterfaz
    {
        public void Metodo()
        {
            Console.WriteLine("Método de la interfaz");
        }
    }


    public class EjemploSiete<T, U> where T : U
    {
        public void Metodo(T objeto)
        {
            Console.WriteLine(objeto.ToString()); // Ejemplo de uso de un método de T
        }
    } 

    class ClaseDerivadaDos : ClaseBase
    {
        // Puedes añadir métodos y propiedades adicionales aquí
    }

}

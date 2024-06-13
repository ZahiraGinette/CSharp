using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Eventos
{
    public class EditorCalculadora
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;

        public void Sumar(int a, int b)
        {
            if(ejemploEvento != null)
            {
                //ejemploEvento.Invoke();
                ejemploEvento();
                Console.WriteLine($"La suma es {a + b}");
            }
            else
            {
                Console.WriteLine("No estas suscrito al evento.");
            }
        }

        public void Restar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La resta es {a + b}");
            }
            else
            {
                Console.WriteLine("No estas suscrito al evento");
            }
        }

    }

    public class SuscriptorCalculadoraVirtual
    {
        private EditorCalculadora editor;
        private int _a;
        private int _b;

        public void EjemploEventHandler()
        {
            Console.WriteLine("La operación va a ser ejecutada");
        }

        public void EjemploEventDosHandler()
        {
            Console.WriteLine("La operación va a ser ejecutada en otro metodo");
        }

        public bool EjemploEventTresHandler()
        {
            Console.WriteLine("La operación va a ser ejecutada en otro metodo");
            return true;
        }


        public SuscriptorCalculadoraVirtual(int a, int b)
        {
            this.editor = new EditorCalculadora();
            this._a = a;
            this._b = b;

            // Nos suscribimos
            editor.ejemploEvento += EjemploEventHandler;
            editor.ejemploEvento += EjemploEventHandler;
            editor.ejemploEvento += EjemploEventHandler;
            editor.ejemploEvento += EjemploEventHandler;
            editor.ejemploEvento += EjemploEventDosHandler;
            // editor.ejemploEvento += EjemploEventTresHandler;

        }

        public void OperacionSuma()
        {
            editor.Sumar(this._a, this._b);
        }

        public void OperacionResta()
        {
            editor.Restar(this._a, this._b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SuscriptorCalculadoraVirtual calculadoraVirtual = new SuscriptorCalculadoraVirtual(2, 3);
            calculadoraVirtual.OperacionSuma();
            calculadoraVirtual.OperacionResta();
            Console.ReadKey();
        }
    }
}

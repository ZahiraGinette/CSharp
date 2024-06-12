using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Delegados_almacenar_metodos_como_atributos
{
    // Delegado para las operaciones matemáticas
    delegate int Operacion(int a, int b);

    // Definimos la clase Calculadora
    class Calculadora
    {
        // Atributo para almacenar el método de operación
        private Operacion operacion;

        // Método para asignar el método de operación
        public void AsignarMetodo(Operacion op)
        {
            operacion = op;
        }

        // Método para realizar la operación almacenada
        public int EjecutarMetodo(int a, int b)
        {
            return operacion(a, b);
        }
    }

    public class Program
    {
        // Métodos de operación
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            // Asignar el método de suma
            calc.AsignarMetodo(Suma);
            Console.WriteLine("Suma: " + calc.EjecutarMetodo(5, 3));

            // Asignar el método de resta
            calc.AsignarMetodo(Resta);
            Console.WriteLine("Resta: " + calc.EjecutarMetodo(5, 3));

            Console.ReadKey();
        }
    }
}

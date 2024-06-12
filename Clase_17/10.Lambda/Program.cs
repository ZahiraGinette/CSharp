using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Labda
{
    public class Program
    {
        static void Main(string[] args)
        {
            // La expresión lambda se representa con =>
            Program programa = new Program();
            Console.WriteLine(programa.CalcularPotenciaAlCuadrado(2));

            Func<int,int> variable = num => num + num;
            Console.WriteLine(variable(3));
            Console.WriteLine(variable(4));

        }
        // Creamos un metodo calcular
        public int CalcularPotenciaAlCuadrado(int numero)
        {
            return numero * numero;
        }
        // Le definimos al parametro el metodo sin tener que llamarlo

    }
}

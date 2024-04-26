using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un programa que permita realizar operaciones matemáticas 
             * simples (suma, resta, multiplicación y división).
             * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
             *      • Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando
             *        y la operación matemática. El método devolverá el resultado de la operación.
             *      • Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe
             *        utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el
             *        operando es distinto de cero.
             * Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
             * El usuario decidirá cuándo finalizar el programa.*/

            Console.Title = "Ejercicio Nro 04";

            double numero1, numero2, resultado;
            string operador;
            bool validacion;
            do
            {
                Console.WriteLine("\nIngrese el primer numero:");
                validacion = double.TryParse(Console.ReadLine(), out numero1);
            } while (validacion == false);

            Console.WriteLine("\nIngrese el operador:");
            operador = Console.ReadLine();

            do
            {
                Console.WriteLine("\nIngrese el segundo numero:");
                validacion = double.TryParse(Console.ReadLine(), out numero2);
            } while (validacion == false);

            resultado = Calculadora.Calcular(numero1, numero2, operador);
            Calculadora.Mostrar(resultado);

            Console.ReadKey();
        }
    }
}

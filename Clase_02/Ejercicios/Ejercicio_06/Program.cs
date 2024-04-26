using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos)
             * que realicen el cálculo del área que corresponda:
             * 
             *      public double CalcularAreaCuadrado(double longitudLado) {}
             *      public double CalcularAreaTriangulo(double base, double altura) {}
             *      public double CalcularAreaCirculo(double radio) {}
             *      
             * El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

            Console.Title = "Ejercicio Nro 06";

            double xbase, altura, resultado, lado, radio;
            bool validacion1, validacion2;

            Console.WriteLine("Calculo de Area:\n");
            Console.WriteLine("Triangulo:");
            do
            {
                Console.WriteLine("\nIngrese la base:");
                validacion1 = double.TryParse(Console.ReadLine(), out xbase);
            } while (validacion1 == false);
            do
            {
                Console.WriteLine("\nIngrese la altura:");
                validacion2 = double.TryParse(Console.ReadLine(), out altura);
            } while (validacion2 == false);

            resultado = CalculoDeArea.CalcularAreaTriangulo(xbase, altura);
            Console.WriteLine("Area del triangulo = {0}\n", resultado);

            Console.WriteLine("Cuadrado:");
            do
            {
                Console.WriteLine("\nIngrese el lado:");
                validacion1 = double.TryParse(Console.ReadLine(), out lado);
            } while (validacion1 == false);

            resultado = CalculoDeArea.CalcularAreaCuadrado(lado);
            Console.WriteLine("Area del cuadrado = {0}\n", resultado);

            Console.WriteLine("Circulo:");
            do
            {
                Console.WriteLine("\nIngrese el radio:");
                validacion1 = double.TryParse(Console.ReadLine(), out radio);
            } while (validacion1 == false);

            resultado = CalculoDeArea.CalcularAreaCirculo(radio);
            Console.WriteLine("Area del circulo = {0}\n", resultado);

            Console.ReadKey();
        }
    }
}

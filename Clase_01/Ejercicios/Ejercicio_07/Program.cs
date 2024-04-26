using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se debe pedir el ingreso por teclado del valor hora, el nombre, 
             * la antigüedad (en años) y la cantidad de horas trabajadas en el 
             * mes de N cantidad de empleados de una fábrica.
             * Se pide calcular el importe a cobrar teniendo en cuenta que el 
             * total (que resulta de multiplicar el valor hora por la cantidad 
             * de horas trabajadas), hay que sumarle la cantidad de años trabajados 
             * multiplicados por $150, y al total de todas esas operaciones 
             * restarle el13% en concepto de descuentos.
             * Mostrar el recibo correspondiente con el nombre, la antigüedad, 
             * el valor hora, el total a cobrar en bruto y el total a 
             * cobrar neto de todos los empleados ingresados. */

            Console.Title = "Ejercicio Nro 07";

            Console.WriteLine("Ingrese la cantidad de empleados:");
            int cantidadEmpleados = int.Parse(Console.ReadLine());

            double totalCobrarBruto = 0;
            double totalCobrarNeto = 0;

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("\nEmpleado " + (i + 1));
                Console.WriteLine("Ingrese el nombre del empleado:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el valor hora del empleado:");
                double valorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la antigüedad del empleado (en años):");
                int antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas trabajadas del empleado en el mes:");
                double horasTrabajadas = double.Parse(Console.ReadLine());

                double totalBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);
                double descuento = totalBruto * 0.13;
                double totalNeto = totalBruto - descuento;

                Console.WriteLine("\nRecibo del empleado:");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Antigüedad: " + antiguedad + " años");
                Console.WriteLine("Valor hora: $" + valorHora);
                Console.WriteLine("Total a cobrar en bruto: $" + totalBruto);
                Console.WriteLine("Total a cobrar neto: $" + totalNeto);

                totalCobrarBruto += totalBruto;
                totalCobrarNeto += totalNeto;
            }

            Console.WriteLine("\nTotales de la fábrica:");
            Console.WriteLine("Total a cobrar en bruto de todos los empleados: $" + totalCobrarBruto);
            Console.WriteLine("Total a cobrar neto de todos los empleados: $" + totalCobrarNeto);

            Console.ReadLine();
        }
    }
}

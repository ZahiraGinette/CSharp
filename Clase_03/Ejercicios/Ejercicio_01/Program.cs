using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            // Crear una nueva cuenta
            Cuenta cuenta = new Cuenta("Juan Perez", 1000);

            // Mostrar los datos iniciales de la cuenta
            Console.WriteLine("Datos iniciales de la cuenta:");
            Console.WriteLine(cuenta.Mostrar());

            // Realizar depósitos y retiros
            cuenta.Ingresar(500);
            cuenta.Retirar(200);
            cuenta.Ingresar(1000);
            cuenta.Retirar(1500);

            // Mostrar los datos finales de la cuenta
            Console.WriteLine("Datos finales de la cuenta:");
            Console.WriteLine(cuenta.Mostrar());

            Console.ReadLine();
        }
    }
}

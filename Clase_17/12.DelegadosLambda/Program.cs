using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Delegados_y_lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, long> multiplicar = (numUno, numDos) => numUno * numDos;

            Action<string> saludar = (nombre) =>
            {
                string saludo = $"Como te va {nombre}?";
                Console.WriteLine(nombre);
            };

            Console.WriteLine($"La muliplicación es {multiplicar(5,9)}");

            saludar("Veronica");

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            // TAREA: Investigar que metodos tiene el list Y VER DELEGADOS

            numeros.ForEach(num =>
            {
                int multiplcacion = num * num; 
                Console.WriteLine($"La multiplicacion de {num} * {num} es: {multiplcacion}");
                // Podemos escribir mas funcionalidad aca
                // ... 
            });

            Console.ReadKey();
        }
    }
}

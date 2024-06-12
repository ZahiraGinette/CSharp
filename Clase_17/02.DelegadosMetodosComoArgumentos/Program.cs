using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Delegados_metodos_como_argumentos
{
    // Usar métodos cómo argumentos 
    public class Program
    {
        /// <summary>
        /// Devuelve verdadero si el número es par
        /// </summary>
        /// <param name="numero">Número a evaluar</param>
        /// <returns>booleano si es par</returns>
        static bool EsPar(int numero)
        {
            return numero % 2 == 0 ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static bool EsImpar(int numero)
        {
            return !EsPar(numero);
        }

        /// <summary>
        /// Función que filtra una lista de números según un criterio dado
        /// </summary>
        /// <param name="numeros">Listado de números a evaluar</param>
        /// <param name="criterio">Representa una función, que recibe un entero y devuelve un booleano</param>
        /// <returns></returns>
        static List<int> Filtrar(List<int> numeros, Func<int, bool> criterio)
        {
            List<int> resultado = new List<int>();
            foreach (int num in numeros)
            {
                if (criterio(num))
                {
                    resultado.Add(num);
                }
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Filtrar los números pares
            var numerosPares = Filtrar(numeros, EsPar);

            var numeroImpares = Filtrar(numeros, EsImpar);

            // Mostrar los números pares
            foreach (int num in numerosPares)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");

            // Mostrar los números pares
            foreach (int num in numeroImpares)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}

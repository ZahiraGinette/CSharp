using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculadoraEstadistica
    {
        public double CalcularPromedio(List<double> numeros)
        {
            if (numeros == null || numeros.Count == 0)
            {
                throw new ArgumentException("La lista de números no puede estar vacía");
            }
            return numeros.Sum() / numeros.Count;
        }

        public double CalcularSuma(List<double> numeros)
        {
            if (numeros == null)
            {
                throw new ArgumentNullException("La lista de números no puede ser nula");
            }
            return numeros.Sum();
        }

        public double CalcularMediana(List<double> numeros)
        {
            if (numeros == null || numeros.Count == 0)
            {
                throw new ArgumentException("La lista de números no puede estar vacía");
            }

            var listaOrdenada = numeros.OrderBy(x => x).ToList();
            int n = listaOrdenada.Count;
            if (n % 2 == 0)
            {
                return (listaOrdenada[(n / 2) - 1] + listaOrdenada[n / 2]) / 2.0;
            }
            else
            {
                return listaOrdenada[n / 2];
            }
        }
    }
}

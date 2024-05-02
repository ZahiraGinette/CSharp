using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Clases_selladas
{
    public sealed class ClaseSellada
    {
        public int Valor { get; set; }

        public ClaseSellada(int valor)
        {
            Valor = valor;
        }

        public void MostrarValor()
        {
            Console.WriteLine($"El valor es: {Valor}");
        }
    }
}

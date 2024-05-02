using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Herencia_clase_derivada
{
    public class ClaseBase
    { 
        private int valorPrivado = 42;
         
        public int Valor { get; set; }
         
        // Constructor de la clase base
        public ClaseBase(int valor)
        {
            Valor = valor;
        }

        public void MostrarValor()
        {
            Console.WriteLine("Valor: " + Valor);
        }
         
        public int ObtenerValorPrivado()
        {
            return valorPrivado;
        }

    }
}

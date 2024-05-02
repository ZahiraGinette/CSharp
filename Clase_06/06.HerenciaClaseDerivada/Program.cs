using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Herencia_clase_derivada
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada derivada = new ClaseDerivada(6,"Nombre");
            derivada.Valor = 10;
            derivada.MostrarValorDeClaseBase(); // Llama a un método heredado de ClaseBase

        }
    }
}

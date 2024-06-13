using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Creacion_Test
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("No se puede dividir por cero");
            }
            return dividendo / divisor;
        }
    }
}

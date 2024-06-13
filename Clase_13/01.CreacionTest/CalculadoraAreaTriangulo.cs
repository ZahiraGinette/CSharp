using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Creacion_Test
{
    public class CalculadoraAreaTriangulo
    {
        public double CalcularArea(double baseTriangulo, double altura)
        {
            if (baseTriangulo <= 0 || altura <= 0)
            {
                throw new ArgumentException("La base y la altura deben ser valores positivos");
            }
            return (baseTriangulo * altura) / 2;
        }
    }
}

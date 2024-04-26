using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConversion
{
    public class DistanciaPies
    {
        private double pies;

        // Constructor
        public DistanciaPies(double pies)
        {
            this.pies = pies;
        }

        // Propiedad de solo escritura
        public double Pies()
        {
            return pies;
        }

        // Operador de conversion explicito de pies a metros
        public static explicit operator DistanciaMetros(DistanciaPies pies)
        {
            double metros = pies.Pies() / 3.28084; // Un pie es aproximadamente 0.3048 metros
            return new DistanciaMetros(metros);
        }

        public static explicit operator NuevaClase(DistanciaPies pies)
        {
            int valor = (int)pies.Pies() * 2;
            return new NuevaClase(valor);
        }

    }
}

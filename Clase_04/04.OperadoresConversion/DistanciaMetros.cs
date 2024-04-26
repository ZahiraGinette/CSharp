using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConversion
{
    public class DistanciaMetros
    {
        private double metros;


        public DistanciaMetros(double metros)
        {
            this.metros = metros;
        }


        public double Metros()
        {
            return this.metros;
        }

        // Operador de conversión implicito de metros a pies
        public static implicit operator DistanciaPies(DistanciaMetros metros)
        {
            double pies = metros.Metros() * 3.28084; // Un metro es aproximadamente 3.28084 pies
            return new DistanciaPies(pies);
        }

        public static implicit operator NuevaClase(DistanciaMetros metros)
        {
            int valor = (int)metros.Metros() * 39;
            return new NuevaClase(valor);
        }

        public static implicit operator int(DistanciaMetros metros)
        {
            return 0;
        }
    }
}

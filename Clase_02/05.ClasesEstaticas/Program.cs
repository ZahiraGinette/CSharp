using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEstaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // No se hace Cotizador cot = new Cotizador(); 
            // cot.CotizarVentaDolares(5);

            // Al ser static se puede llamar al metodo con la clase

            decimal abono = Cotizador.AbonarVentaDolares(70);
            decimal cotizar = Cotizador.CotizarVentaDolares(5);
            decimal segundoAbono = Cotizador.AbonarVentaDolares(2);
        }

        private int Suma(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }
    }
}

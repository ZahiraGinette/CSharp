using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEstaticas
{
    public static class Cotizador
    {
        private const decimal pesosPorDolarComprado = 1000.75M;
        private const decimal pesosPorDolarVendido = 950.75M;

        public static decimal CotizarVentaDolares(decimal montoDolaresAVender)
        {
            decimal costoEnPesos = montoDolaresAVender * pesosPorDolarVendido;

            return costoEnPesos;
        }

        public static decimal AbonarVentaDolares(decimal montoDolaresAComprar)
        {
            decimal pagoEnPesos = montoDolaresAComprar * pesosPorDolarComprado;

            return pagoEnPesos;
        }

    }
}

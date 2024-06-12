using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Delegados_Func
{
    public class Program
    {
        static double CalcularDosisMedicamento(double peso)
        {
            return peso * 0.02;
        }

        static void Main(string[] args)
        {
            // Se define una función que toma el peso del paciente como parámetro y devuelve la dosis de medicamento
            Func<double, double> calcularDosis = CalcularDosisMedicamento;

            // Se llamá a la función
            double dosis = calcularDosis(70); // 70 kg de peso
            Console.WriteLine($"La dosis de medicamento a administrar es: {dosis} mg.");
        }
    }
}

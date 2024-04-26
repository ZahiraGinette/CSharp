using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    public class Calculadora
    {
        private double resultado;

        public Calculadora(double resultadoInicial)
        {
            resultado = resultadoInicial;
        }

        // Sobrecarga del operador de suma (+)
        public static double operator +(Calculadora calc, double num)
        {
            return calc.resultado + num;
        }


        // Sobrecarga del operador de resta (-)
        public static double operator -(Calculadora calc, double num)
        {
            return calc.resultado - num;
        }

        // Sobrecarga del operador de multiplicación (*)
        public static string operator *(Calculadora calc, double num)
        {
            return $"{calc.resultado.ToString()} y {num}";
        }

        // Sobrecarga del operador de división (/)
        public static double operator /(Calculadora calc, double num)
        {
            if (num != 0)
                return calc.resultado / num;
            else
                return 0;
        }

        public double ObtenerResultado()
        {
            return resultado;
        }

        public void Limpiar()
        {
            resultado = 0;
        }


    }
}

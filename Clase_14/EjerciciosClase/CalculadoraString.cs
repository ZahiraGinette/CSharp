using System;
using System.Collections.Generic;

namespace Ejercicios
{
    public class CalculadoraString
    {
        public int Add(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
                return 0;

            var delimitadores = ObtenerDelimitadores(ref numeros);

            var numerosSeparados = SepararNumeros(numeros, delimitadores);

            ValidarNegativos(numerosSeparados);

            return SumarNumeros(numerosSeparados);
        }

        private List<char> ObtenerDelimitadores(ref string numeros)
        {
            var delimitadores = new List<char> { ',', '\n' };

            if (numeros.StartsWith("//"))
            {
                var delimitador = numeros[2];
                delimitadores.Add(delimitador);

                // Eliminamos la parte de la cadena que contiene el delimitador
                numeros = numeros.Substring(numeros.IndexOf('\n') + 1);
            }

            return delimitadores;
        }

        private List<int> SepararNumeros(string numeros, List<char> delimitadores)
        {
            var numerosSeparados = new List<int>();
            var numerosActuales = new List<char>();

            foreach (var caracter in numeros)
            {
                if (delimitadores.Contains(caracter))
                {
                    if (numerosActuales.Count > 0)
                    {
                        numerosSeparados.Add(int.Parse(new string(numerosActuales.ToArray())));
                        numerosActuales.Clear();
                    }
                }
                else
                {
                    numerosActuales.Add(caracter);
                }
            }

            // Añadir el último número si no está vacío
            if (numerosActuales.Count > 0)
            {
                numerosSeparados.Add(int.Parse(new string(numerosActuales.ToArray())));
            }

            return numerosSeparados;
        }

        private void ValidarNegativos(List<int> numeros)
        {
            foreach (var numero in numeros)
            {
                if (numero < 0)
                {
                    throw new NegativoNoPermitidoException($"Negativos no permitidos: {numero}");
                }
            }
        }

        private int SumarNumeros(List<int> numeros)
        {
            int suma = 0;
            foreach (var numero in numeros)
            {
                suma += numero;
            }
            return suma;
        }
    }
}

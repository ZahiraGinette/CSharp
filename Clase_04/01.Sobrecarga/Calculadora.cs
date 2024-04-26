using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Calculadora
    {
        #region Sobrecarga metodos
        /// <summary>
        /// Método Sumar para sumar dos números enteros
        /// </summary>
        /// <param name="operadorUno"></param>
        /// <param name="operadorDos"></param>
        /// <returns></returns>
        public int Sumar(int operadorUno, int operadorDos)
        {
            return operadorUno + operadorDos;
        }

        /// <summary>
        ///  Método Sumar para sumar tres números enteros
        /// </summary>
        /// <param name="operadorUno"></param>
        /// <param name="operadorDos"></param>
        /// <param name="operadorTres"></param>
        /// <returns></returns>
        public int Sumar(int operadorUno, int operadorDos, int operadorTres)
        {
            return operadorUno + operadorDos + operadorTres;
        }

        /// <summary>
        /// Método Sumar para sumar dos números decimales
        /// </summary>
        /// <param name="operadorUno"></param>
        /// <param name="operadorDos"></param>
        /// <returns></returns>
        public int Sumar(float operadorUno, float operadorDos)
        {
            return (int)(operadorUno + operadorDos);
        }


        /// <summary>
        /// Método Sumar para sumar dos números decimales
        /// </summary>
        /// <param name="operadorUno"></param>
        /// <param name="operadorDos"></param>
        /// <returns></returns>
        public float Sumar(float operadorUno, int operadorDos)
        {
            return (int)(operadorUno + operadorDos);
        }

        /// <summary>
        /// Método Sumar para sumar dos números decimales
        /// </summary>
        /// <param name="operadorUno"></param>
        /// <param name="operadorDos"></param>
        /// <returns></returns>
        public float Sumar(int operadorUno, float operadorDos)
        {
            return (int)(operadorUno + operadorDos);
        }

        public double Sumar(double operadorUno, double operadorDos)
        {
            return operadorUno + operadorDos;
        }

        public double Sumar(float operadorUno, float operadorDos, int operadorTres)
        {
            return operadorUno + operadorDos;
        }


        public void Sumar(string operadorUno, float operadorDos)
        {
            Console.Write(operadorUno);
        }

        public void Sumar(float operadorDos, string operadorUno)
        {
            Console.Write(operadorUno);
        }


        #endregion

        #region Buenas practicas

        // Forma incorrecta
        //public int Restar(int a, int b)
        //{
        //    return a - b;
        //}

        //// Forma incorrecta
        //public int Restar(int a, int b, int z)
        //{
        //    return a - b - z;
        //}

        public int Restar(int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;
        }

        public int Restar(int minuendo, int sustraendo, int sustraendo2)
        {
            return minuendo - sustraendo - sustraendo2;
        }





        #endregion

    }
}

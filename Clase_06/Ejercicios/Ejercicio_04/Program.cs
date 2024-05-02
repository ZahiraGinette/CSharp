using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 5, ETipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)(i+1), azar.Next(1, 5).ToString(), (short)azar.Next(800, 1000));

                if(formulaUno + autos[i])
                {
                    Console.WriteLine("Se agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }else
                {
                    Console.WriteLine("No se agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
            }

            Console.WriteLine();
            Console.WriteLine("<---------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}

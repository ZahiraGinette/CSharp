using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            Equipo equipo = new Equipo(2, "utn");
            Jugador j1 = new Jugador(123456789, "Juan", 3, 1);
            Jugador j2 = new Jugador(159486748, "Carlos", 3, 5);
            Jugador j3 = new Jugador(845958425, "Alberto", 7, 3);
            Jugador j4 = new Jugador(123456789, "Patricia", 3, 5);

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());

            Console.ReadKey();
        }
    }
}

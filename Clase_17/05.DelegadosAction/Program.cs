using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Delegados_Action
{
    public class Program
    {
        static void RegistrarEntrada(string nombre)
        {
            Console.WriteLine($"El paciente {nombre} ha sido registrado.");
        }

        static void Main(string[] args)
        {
            // Se define una acción que toma el nombre del paciente como parámetro
            Action<string> registrarPaciente = RegistrarEntrada;

            // Se llamá a la acción
            registrarPaciente("Roberto Carlos"); // Imprime: El paciente Juan ha sido registrado.

            Console.ReadKey();
        }
    }
}

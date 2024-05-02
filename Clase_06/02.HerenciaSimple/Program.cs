using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Herencia_simple
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear una persona
            Persona persona = new Persona("Carlos", 40, "Masculino");
            persona.MostrarInformacion(); 
            Console.WriteLine(); 

            // Crear un estudiante
            Estudiante estudiante = new Estudiante("Laura", 20, "Femenino", "Grado en Informática");
            estudiante.Estudiar();

            Console.ReadKey();
        }
    }
}

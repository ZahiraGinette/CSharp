using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_b.Herencia_correcta
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear un profesor
            Profesor profesor = new Profesor("Juan", "Perez", 12345678, "Matemáticas");
            Console.WriteLine(profesor.Corregir());

            // Crear un estudiante
            List<string> materias = new List<string> { "Matemeticas", "Fisica", "Quimica" };
            Estudiante estudiante = new Estudiante("Ana", "Gómez", 87654321, "1001", materias);
            Console.WriteLine(estudiante.Estudiar());

            Console.ReadKey();
        }
    }
}

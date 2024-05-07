using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ClaseAbastractca
{
    public class Program
    {
        static void Main(string[] args)
        { 
            // Variables con tipos abstractos
            Persona persona1 = null;
            Persona persona2 = null;

            // No se puede crear instancias de una clase abstracta directamente
            // persona1 = new Persona(); // Esto arrojaría un error en tiempo de compilación

            // Pero podemos asignar instancias de clases concretas a variables con tipo abstracto
            persona1 = new Estudiante("Juan", 20, "Matemáticas");

            persona2 = new Profesor("Monica", 37, "Física");
              
            // Saludar
            persona1.Saludar();
            persona2.Saludar();

            Console.ReadKey();
        }
    }
}

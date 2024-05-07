using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sobreescritura_equivalencias
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", "12345678");
            Persona persona2 = new Persona("Maria", "87654321");
            Persona persona3 = new Persona("Juan", "12345678");
            Libro libro = new Libro();
            
             
            // Usando ToString()
            Console.WriteLine("Persona 1: " + persona1.ToString());
            // ToString() se llama implicitamente
            Console.WriteLine("Persona 2: " + persona2); 
            Console.WriteLine("Persona 3: " + persona3);

            Console.ReadKey();

            // Usando GetHashCode()
            Console.WriteLine("HashCode de Persona 1: " + persona1.GetHashCode());
            Console.WriteLine("HashCode de Persona 2: " + persona2.GetHashCode());
            Console.WriteLine("HashCode de Persona 3: " + persona3.GetHashCode());

            Console.ReadKey();

            // Usando Equals()
            Console.WriteLine("¿Persona 1 es igual a Persona 2? " + persona1.Equals(persona2));  
            Console.WriteLine("¿Persona 1 es igual a Persona 3? " + persona1.Equals(persona3));

            Console.ReadKey();

        }
    }
}

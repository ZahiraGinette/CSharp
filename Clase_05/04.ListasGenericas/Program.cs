using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasGenericas
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear una matriz de personas
           /* Persona[,] personas1 = new Persona[2,2];
            personas1[0, 0] = new Persona("Pedrito", 22);
            Console.WriteLine(personas1[0,0].Edad);*/

            List<Persona> personas = new List<Persona>();

            Persona personaUno = new Persona("Veronica", 77); 

            // Agregar personas a la lista
            personas.Add(new Persona("Juan", 30));
            personas.Add(new Persona("María", 25));
            personas.Add(new Persona("Pedro", 35)); 
            personas.Add(new Persona("Florencia", 35));
            personas.Add(new Persona("Carlos", 22));
            personas.Add(new Persona("Veronica", 77));


            for (int i = 0; i < personas.Count; i++)
            {
                Console.WriteLine(personas[i].Edad);
            }

            Console.WriteLine(personas.Count);

            // Eliminar elementos
            personas.Remove(personas[1]); // Eliminamos a maria
            personas.RemoveAt(1);

            // Iterar sobre la lista y saludar a cada persona
            Console.WriteLine("Saludos de las personas en la lista:");
            foreach (Persona persona in personas)
            {
                persona.Saludar();
            }

            Console.WriteLine(personas.Count);

            Console.ReadKey();


            // Buscar elementos 
            bool buscar = personas.Contains(personaUno);
            Console.WriteLine("La lista posee a Veronica? : " + buscar);

            int indice = personas.IndexOf(personaUno);
            Console.WriteLine($"El indice de Veronica es {indice}");

            Persona mayorTreinta = personas.Find(p => p.Edad > 30); // Encuentra la primer persona mayor a 30
            Console.WriteLine($"Primera persona mayor de 30 años: {mayorTreinta.Nombre}");

            List<Persona> mayores = personas.FindAll(p => p.Edad > 30); // Todas las personas mayores de 30
            Console.WriteLine("Personas mayores de 30 años:");
            foreach (var persona in mayores)
            {
                persona.Saludar();
            }

            // Modificar elementos
            personas.Insert(1, new Persona("Carlos", 40)); // Inserta a Carlos en el indice 1
            personas.Reverse(); // Invierte el orden de la lista

            Console.WriteLine("Despues de invertir la lista:");
            foreach (var persona in personas)
            {
                persona.Saludar();
            }

            personas.Sort((p1, p2) => p1.Edad.CompareTo(p2.Edad)); // Ordena por edad

            Console.WriteLine("Después de ordenar por edad:");
            foreach (var persona in personas)
            {
                persona.Saludar();
            }

            // Obtener un subconjunto
            List<Persona> subset = personas.GetRange(1, 2); // Obtiene dos elementos desde el indice 1
            Console.WriteLine("Subconjunto de la lista:");
            foreach (var persona in subset)
            {
                persona.Saludar();
            }
             
            Console.ReadKey();
        }
    }
}

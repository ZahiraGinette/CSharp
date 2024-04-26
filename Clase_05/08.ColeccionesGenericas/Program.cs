using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesGenericas
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List
            Console.WriteLine("Ejemplo de List:");
            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona("Juan", 30));
            listaPersonas.Add(new Persona("María", 25));
            foreach (var persona in listaPersonas)
            {
                Console.WriteLine(persona.Saludar());
            }
            Console.ReadKey();

             
            // Dictionary
            Console.WriteLine("Ejemplo de Dictionary:");
            Dictionary<string, Persona> diccionarioPersonas = new Dictionary<string, Persona>();
            diccionarioPersonas.Add("Primero", new Persona("Juan", 30));
            diccionarioPersonas.Add("Segundo", new Persona("María", 25));

            foreach (var kvp in diccionarioPersonas)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value.Saludar()}");
            }
            Console.ReadKey();

             
            // Queue
            Console.WriteLine("Ejemplo de Queue:");
            Queue<Persona> colaPersonas = new Queue<Persona>();
            colaPersonas.Enqueue(new Persona("Juan", 30));
            colaPersonas.Enqueue(new Persona("María", 25));
            colaPersonas.Dequeue();
            while (colaPersonas.Count > 0)
            {
                Console.WriteLine(colaPersonas.Dequeue().Saludar());
            }
            Console.ReadKey();
             

            // Stack
            Console.WriteLine("Ejemplo de Stack:");
            Stack<Persona> pilaPersonas = new Stack<Persona>();
            pilaPersonas.Push(new Persona("Juan", 30));
            pilaPersonas.Push(new Persona("María", 25));
            while (pilaPersonas.Count > 0)
            {
                Console.WriteLine(pilaPersonas.Pop());
            }
            Console.ReadKey();

           
        }
    
    }
}

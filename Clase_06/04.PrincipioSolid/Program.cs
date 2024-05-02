using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Principio_solid
{
    public class Program
    {
        static void Main(string[] args)
        { 
            // T objeto = new S();

            Animal animal = new Perro(); 
            animal.HacerSonido(); 
             
            Perro perro = new Perro();
            Animal segundoAnimal = new Perro();
             
            Persona persona = new Alumno(); 
            persona.Identificarse();

            Console.ReadKey();

        }
    }

    // Clase base
    public class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    // Subclase
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra.");
        }
    }



    // Clase base
    public class Persona
    {
        public virtual void Identificarse()
        {
            Console.WriteLine("Soy una persona.");
        }
    }

    // Subclase
    public class Alumno : Persona
    {
        public override void Identificarse()
        {
            Console.WriteLine("Soy un alumno.");
        }
    }

}

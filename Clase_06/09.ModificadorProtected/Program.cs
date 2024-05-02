using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Modificador_protected
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de NuevaClase
            NuevaClase nuevaClase = new NuevaClase();

            // Crear una instancia de Persona
            Persona persona = new Persona("Carlos");
            
            // persona.MostrarInformacion(); // Metodo protected, no es posible acceder al mismo 

            // Crear una instancia de Estudiante
            Estudiante estudiante = new Estudiante("Ana", 87654321, "Grado en Informática");

            // Acceder a un método que usa los miembros protegidos
            estudiante.MostrarInformacionCompleta(); // Puede acceder a los miembros protegidos
          
            Console.ReadKey();
        }
    }
}

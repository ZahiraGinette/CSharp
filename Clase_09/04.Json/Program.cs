using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks; 

namespace Json
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Roberto",33,"Perez");
            string jsonString = JsonSerializer.Serialize(empleado); // De no tener JsonSerializer, se debera instalar el paquete

            Console.WriteLine(jsonString);

            // Deserialización
            Empleado empleadoDeserealizado = JsonSerializer.Deserialize<Empleado>(jsonString);
             
            Console.ReadKey();
        }
    }
}

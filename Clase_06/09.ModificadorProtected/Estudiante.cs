using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Modificador_protected
{
    public class Estudiante : Persona
    {
        private string grado;
        // Constructor
        public Estudiante(string nombre, long dni, string grado) : base(nombre)
        {
            this.grado = grado;
        }

        public Estudiante(long dni) : base(dni)
        { 
        }

        public void MostrarInformacionCompleta()
        {
            // Accede a miembros protegidos de la clase base
            Console.WriteLine($"Nombre: {nombre}, DNI: {dni}, Grado: {grado}");
        }

        public void AccederAClaseBase(Persona persona)
        {
            // Esto generaría un error porque no se puede acceder a miembros protegidos desde referencias a la clase base
            //persona.nombre = "Error"; 
           
            persona.MostrarInformacion();
            
            MostrarInformacion();
        }

    }
}

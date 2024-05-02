using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Constructores
{
    public class Estudiante : Persona
    {
        protected int legajo;
        protected List<string> materias; 
         
        // Constructor
        public Estudiante(int legajo, List<string> materias, string nombre) : base(nombre)
        {
            this.legajo = legajo;
            this.materias = materias; 
        }

        public Estudiante(int legajo,long dni) :base(dni)
        { 
            this.legajo = (int)legajo;
        }
         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Excepciones_propias
{
    public class Program
    {

    }

    public class Clase
    {
        private int id;
        private static string nombre;

        public Clase() 
        {
            this.id = 0;
            nombre = "hola";
        }

        protected virtual int Id
        {
            get
            {
                return this.id;
            }
            set { this.id = value; }
        }

    }

    public class ClaseDos : Clase
    {
        private int edad;
        private  string apellido;

        protected override int Id { get => base.Id; set => base.Id = value; }


    }
}

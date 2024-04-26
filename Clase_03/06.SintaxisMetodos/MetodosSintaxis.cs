using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxisMetodos
{
    public class MetodosSintaxis
    {
        private string nombre;

        public string Saludar()
        {
            return $"Hola mi nombre es {this.nombre}";
        }

        //abstract string  MetodoAbstracto();

        //extern void MetodoExterno();
        
        internal void MetodoInternal()
        {

        }
         
        //public override void MetodoOverride()
        //{

        //}

        public virtual void MetodoVirtual()
        {

        }

    }
}

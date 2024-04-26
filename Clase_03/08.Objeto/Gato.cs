using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{
    public class Gato : Mascota
    {
        public Gato(string nombre, int edad, string raza, string especie) : base(nombre, edad, raza, especie)
        {
        }
    }
}

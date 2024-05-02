using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Transitividad
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClaseA claseA = new ClaseA();
            ClaseB claseB = new ClaseB();
            ClaseC claseC = new ClaseC();

            claseB.MetodoUno();
            claseB.MetodoTres();

            claseC.MetodoUno();
            claseC.MetodoDos();
            claseC.MetodoTres();
        }
    }
}

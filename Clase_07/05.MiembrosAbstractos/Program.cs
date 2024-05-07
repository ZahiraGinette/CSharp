using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Miembros_abstractos
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // Creamos clases

    public abstract class A
    {
        public abstract void F();
    }

    public abstract class B : A
    {
        public void G() { }
    }

    public class C : B
    {
        public override void F()
        {
            
        }
    }
}

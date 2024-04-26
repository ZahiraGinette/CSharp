// Directiva USING
using System;
using System.Collections.Generic;
using System.Linq;
using ST = System.Text;
using System.Threading.Tasks;
using SD = System.Console; // Directiva ALIAS
using OtroNamespace;

namespace NamespacesYDirectivas
{
    public class Program
    {
        static void Main(string[] args)
        {
            SegundoEjemplo.Saludo();

            PrimerEjemplo.Saludo();
        }
    }
}

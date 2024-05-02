using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Herencia_clase_derivada
{
    public class ClaseDerivada : ClaseBase
    {
        public string Nombre { get; set; }

        // Constructor de la clase derivada

        // Una clase derivada hereda todo de su clase base, excepto los constructores. Por lo tanto necesita un constructor
        public ClaseDerivada(int valor, string nombre) : base(valor) // Llamada al constructor de la clase base
        {
            Nombre = nombre;
        }

        public void MostrarValorDeClaseBase()
        {
            // Acceso al metodo público de la clase base
            MostrarValor();
        }

        public void MostrarValorPrivado()
        {
            // Esto no es posible:
            // Console.WriteLine(valorPrivado); // Miembro privado no accesible

            // Pero puedes usar un método público para acceder al valor privado
            Console.WriteLine(ObtenerValorPrivado());
        }
    }
}

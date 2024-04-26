using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenasPracticas
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        /* Buenas practicas en metodos */
        // Nombres descriptivos
        public int RealizarSuma(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }

        // PascalCase 
        private string MostrarMensaje()
        {
            return "Hola";
        }

        private void Calcular()
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDRY
{
    public class Program
    {
        // NO usando DRY
        #region No usando DRY

        public void HacerTe(string tipo, bool conAzucar)
        {
            Console.WriteLine("Agua hervida. ");
            if (conAzucar) // como es un bool, no es necesario hacer conAzucar == true
            {
                Console.WriteLine("Agregar azucar. ");
            }

            Console.WriteLine("Preparando el te de {0}", tipo);
        }

        public void HacerCafe(bool conAzucar)
        {
            Console.WriteLine("Agua hervida. ");
            if (conAzucar)
            {
                Console.WriteLine("Agregar azucar. ");
            }

            Console.WriteLine("Preparando cafe");
        }
        #endregion

        #region Usando DRY

        public void AguaHervidaYAzucar(bool conAzucar)
        {
            Console.WriteLine("Agua hervida. ");
            if (conAzucar)
            {
                Console.WriteLine("Agregar azucar. ");
            }
        }

        public void HacerTeDRY(string tipo, bool conAzucar)
        {
            AguaHervidaYAzucar(conAzucar);
            Console.WriteLine("Preparando el te de {0}", tipo);
        }

        public void HacerCafeDRY(bool conAzucar)
        {
            AguaHervidaYAzucar(conAzucar);
            Console.WriteLine("Preparando cafe");
        }


        #endregion
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso_Ejemplos
{
    #region Metodo protected
    public class ClaseDos : ClaseUno  // Deriva de ClaseUno
    {
        public void MetodoClaseDos()
        {
            Console.WriteLine("Es un metodo de clase");
            MetodoCuatro(); // Se puede llamar porque hereda de claseUno
        }
    }
    #endregion

    // Nuestra clase program
    public class Program
    {
        static void Main(string[] args)
        {
            ClaseUno.MetodoUno(); // Llamamos al metodo publico

            //ClaseUno.MetodoDos(); // No se puede llamar porque es privado

            ClaseUno.MetodoTres(); // Se puede llamar porque esta dentro del mismo proyecto

            //ClaseUno.MetodoCuatro(); // No se puede llamar porque solo los derivados pueden usarlo
        }
    }
}

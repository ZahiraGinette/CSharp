using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Delegados_Predicate
{
    public class Program
    {
        static bool EstaEnCondicionesParaAlta(int temperatura)
        {
            return temperatura <= 37;
        }

        static void Main(string[] args)
        {
            // Se define un predicado que toma la temperatura del paciente y devuelve un booleano
            Predicate<int> condicionAlta = EstaEnCondicionesParaAlta;

            // Se evalua el predicado
            bool puedeSerDadoDeAlta = condicionAlta(36);
            Console.WriteLine($"¿El paciente puede ser dado de alta? {puedeSerDadoDeAlta}");
        }
    }
}

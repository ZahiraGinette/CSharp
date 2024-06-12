using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Interfaces
{
    // MODIFICADOR + interface + Nombre interfaz
    public interface Interface1
    {
        // No se permite definir atributos ni constructores
        // public interface1(){}
        // public int atributo;

        string Mensaje(); // Los metodos por defectos siempre seran publico

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasConcurrentes
{
    public class Emoji
    {
        public string Nombre { get; }
        public string Icono { get; }

        public Emoji(string nombre, string icono)
        {
            Nombre = nombre;
            Icono = icono;
        }

        public string Mostrar()
        {
            return $"{Nombre}: {Icono}";
        }
    }
}

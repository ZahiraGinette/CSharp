using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstructores
{
    public class Impresora
    {
        private string _marca;
        private string _modelo;
        private bool _multifuncional;
        private int _hpm;
        private float _precio;

        public Impresora()
        {

        }

        public Impresora(string marca, string modelo)
        {
            this._marca = marca;
            this._modelo = modelo;
        }

        public Impresora(string marca, string modelo, bool multifuncional, int hpm) : this(marca, modelo)
        {
            this._multifuncional = multifuncional;
            _hpm = hpm;
        }

        public Impresora(string marca, string modelo, float precio) : this(marca, modelo)
        {
            _precio = precio;
        }

        public Impresora(float precio)
        {
            _precio = precio;

        }

        public void MetodoMostrar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

    }
}

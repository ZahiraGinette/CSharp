using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Xml_textWritter
{
    public class Producto
    {
        private string _nombre;
        private double _precio; 
    
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
         public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Producto() { }
  
        public Producto(string nombre, double precio )
        {
            Nombre = nombre;
            Precio = precio; 
        }
    }
}

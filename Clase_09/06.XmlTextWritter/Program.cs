using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XmlTextWritter
{
    public class Program
    {
        static void Main(string[] args)
        {  
          
            XmlTextReader reader = new XmlTextReader(@"Xml\Serealizacion.xml");

            XmlSerializer ser = new XmlSerializer(typeof(Producto));

            Producto nuevoProducto = (Producto)ser.Deserialize(reader);

            reader.Close();

            Console.ReadKey();
        }
    }
}

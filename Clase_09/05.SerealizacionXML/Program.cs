using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _05.Serealizacion_XML
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Producto
            Producto producto = new Producto("Manzana", 1000, 5);

            // Se indica ubicación del archivo XML y su codificación
            string filePath = @"Xml\Serealizacion.xml";

            // Se crea un XmlTextWriter para escribir en el archivo XML
            using (XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8))
            {
                // Se indica el tipo de objeto a serializar
                XmlSerializer serializer = new XmlSerializer(typeof(Producto));

                // Serializa el objeto producto en el archivo contenido en el writer
                serializer.Serialize(writer, producto);
            }

            Console.WriteLine("Objeto serializado correctamente en: " + filePath); 
            Console.ReadKey();

        }
    }
}

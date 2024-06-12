using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace Ejercicio_03
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                using (TextWriter writer = new StreamWriter(""))
                {
                    serializer.Serialize(writer, persona);
                }
                Console.WriteLine("Persona guardada en XML.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar en XML: " + ex.Message);
            }
        }

        public static Persona Leer()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                using (TextReader reader = new StreamReader(""))
                {
                    return (Persona)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer en XML: " + ex.Message);
                return null;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Apellido: {apellido}";
        }

        public static void GuardarJson(Persona persona)
        {
            try
            {
                string json = JsonSerializer.Serialize(persona);
                File.WriteAllText("", json);
                Console.WriteLine("Persona guardada en JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar en JSON: " + ex.Message);
            }
        }

        public static Persona LeerJson()
        {
            try
            {
                string json = File.ReadAllText("");
                return JsonSerializer.Deserialize<Persona>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer en JSON: " + ex.Message);
                return null;
            }
        }
    }
}

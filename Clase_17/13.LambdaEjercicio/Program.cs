using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Lambda_ejercicio
{
    class Producto
    { 
        private string nombre;
        private decimal precio;
        private int cantidad;
         
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
         
        public Producto(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Método para mostrar la información del producto
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio}, Cantidad: {Cantidad}");
        }
    }

    // Clase Supermercado
    class Supermercado
    {
        private List<Producto> productos;
         
        public Supermercado()
        {
            productos = new List<Producto>();
        }
         
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
         
        public void ActualizarPrecios(Func<Producto, decimal> actualizarPrecio)
        {
            foreach (var producto in productos)
            {
                producto.Precio = actualizarPrecio(producto);
            }
        }

        // Método para mostrar la información de los productos
        public void MostrarProductos()
        {
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un programa en C# que simule la gestión de productos en un supermercado. Para ello, realizar los siguientes pasos:

            Definir una clase Producto que tenga los siguientes atributos privados, propiedades y constructores que inicialicen:

            -> Nombre: Una cadena que representa el nombre del producto.
            -> Precio: Un decimal que indica el precio del producto.
            -> Cantidad: Un entero que representa la cantidad disponible del producto en el inventario.

            Dentro de la clase Producto, definir los siguientes métodos:
                
            -> MostrarInformacion(): Un método que muestra el nombre, precio y cantidad del producto.
            
            Definir una clase Supermercado que tenga una lista de productos como propiedad.

            En la clase Supermercado, definir un método ActualizarPrecios que toma un delegado como parámetro.
            Este delegado debe tomar un producto como argumento y devolver un decimal que representa el nuevo precio del producto. 
            Dentro del método ActualizarPrecios, utiliza una expresión lambda para actualizar el precio de cada producto en la lista 
            utilizando el delegado proporcionado.

            En el método Main:

            * Crea una instancia de la clase Supermercado.
            * Agregar varios productos a la lista de productos del supermercado.
            * Definir un delegado que toma un producto y aumenta su precio en un 10 %.
            * Llamar al método ActualizarPrecios del supermercado, pasando el delegado como argumento.
            * Muestra la información de todos los productos después de actualizar los precios.*/


            #region Ejercicio resuelto
            Supermercado supermercado = new Supermercado();
             
            supermercado.AgregarProducto(new Producto("Leche", 2.5m, 50));
            supermercado.AgregarProducto(new Producto("Pan", 1.0m, 100));
            supermercado.AgregarProducto(new Producto("Huevos", 3.0m, 30));
             
            supermercado.ActualizarPrecios(producto => producto.Precio * 1.1m);
             
            Console.WriteLine("Información de productos después de actualizar precios:");
            supermercado.MostrarProductos();
            Console.ReadKey();
            #endregion
        }
    }
}

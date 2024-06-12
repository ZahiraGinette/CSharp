using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Delegados_ejercicio
{
    public class Program
    {
        #region Clase resuelta
        delegate void AccionVehiculo();

        // Clase Vehiculo
        class Vehiculo
        {
            private string _marca;
            private bool _encendido;
             
            public string Marca
            {
                get { return _marca; }
                set { _marca = value; }
            }

            public bool Encendido
            {
                get { return _encendido; }
                set { _encendido = value; }
            }

            public Vehiculo() { }

            public Vehiculo(string marca, bool encendido) {
                this._marca = marca;
                this._encendido = encendido;
            }


            public void Encender()
            {
                Console.WriteLine($"{Marca} encendido");
                Encendido = true;
            }
             
            public void Apagar()
            {
                Console.WriteLine($"{Marca} apagado");
                Encendido = false;
            }
             
            public void VerificarEstado()
            {
                Console.WriteLine($"{Marca} está encendido: {Encendido}");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            /*
                1) Definir un delegado
                
                2) Definir una clase Vehiculo tenga los siguientes atributos privados y propiedades:

                * Marca: Una cadena que representa la marca del vehículo.
                * Encendido: Un booleano que indica si el vehículo está encendido o apagado.
                
                3) Dentro de la clase Vehiculo, definir los siguientes métodos:

                * Encender(): Un método que cambia el estado del vehículo a encendido y muestra un mensaje indicando que el vehículo ha sido encendido.
                * Apagar(): Un método que cambia el estado del vehículo a apagado y muestra un mensaje indicando que el vehículo ha sido apagado.
                * VerificarEstado(): Un método que muestra un mensaje indicando si el vehículo está encendido o apagado.
                
                4) "Utiliza delegados para representar las acciones de encender, apagar y verificar el estado del vehículo."

                5) En el método Main:

                * Crea una instancia de la clase Vehiculo.
                * Definir los delegados para cada una de las acciones del vehículo.
                * Invoca los delegados para realizar las acciones respectivas.
                * Utilizar cualquier ejemplo.
            */

            #region Ejercicio resuelto
            Vehiculo miVehiculo = new Vehiculo("Toyota",  false);

                // Definimos delegados para las acciones del vehículo
                AccionVehiculo encender = miVehiculo.Encender;
                AccionVehiculo apagar = miVehiculo.Apagar;
                AccionVehiculo verificarEstado = miVehiculo.VerificarEstado;

                // Ejecutamos las acciones
                encender();
                verificarEstado();
                apagar();
                verificarEstado();

                Console.ReadKey();
            #endregion
        }
    }
}

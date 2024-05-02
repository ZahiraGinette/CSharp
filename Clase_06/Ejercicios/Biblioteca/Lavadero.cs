using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un lavadero de vehículos.
    /// </summary>
    public class Lavadero
    {
        #region Atributos
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de solo lectura que devuelve la lista de vehículos en el lavadero.
        /// </summary>
        public List<Vehiculo> Vehiculos
        {
            get
            {
                return _vehiculos;
            }
        }


        /// <summary>
        /// Propiedad de sólo lectura que retorna la información completa del lavadero.
        /// </summary>
        public string Detalle
        {
            get
            {
                string retorno = "";

                foreach (Vehiculo vehiculo in _vehiculos)
                {
                    if (vehiculo is Auto auto)
                    {
                        retorno += "=============== AUTO ==================\n";
                        retorno += auto.MostrarAuto();
                        retorno += "\n\n\n";
                    }
                    else if (vehiculo is Moto moto)
                    {
                        retorno += "=============== MOTO ==================\n";
                        retorno += moto.MostrarMoto();
                        retorno += "\n\n\n";
                    }
                    else if (vehiculo is Camion camion)
                    {
                        retorno += "=============== CAMION ==================\n";
                        retorno += camion.MostrarCamion();
                        retorno += "\n\n\n";
                    }
                }

                return retorno;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de la clase Lavadero.
        /// </summary>
        private Lavadero()
        {
            _vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor de la clase Lavadero.
        /// </summary>
        /// <param name="precioAuto">El precio de lavado para autos.</param>
        /// <param name="precioCamion">El precio de lavado para camiones.</param>
        /// <param name="precioMoto">El precio de lavado para motos.</param>
        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            _precioAuto = precioAuto;
            _precioCamion = precioCamion;
            _precioMoto = precioMoto;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método para calcular la ganancia del lavadero por tipo de vehículo.
        /// </summary>
        /// <param name="tipoVehiculo">Tipo de vehículo.</param>
        /// <returns>Ganancia del lavadero por tipo de vehículo.</returns>
        public double MostrarTotalFacturado(Lavadero lavadero)
        {
            double precioTotal = 0;

            foreach (Vehiculo vehiculo in lavadero._vehiculos)
            {
                precioTotal += lavadero._precioAuto + lavadero._precioCamion + lavadero._precioMoto;
            }

            return precioTotal;
        }

        /// <summary>
        /// Método para calcular la ganancia del lavadero por tipo de vehículo.
        /// </summary>
        /// <param name="tipoVehiculo">Tipo de vehículo.</param>
        /// <returns>Ganancia del lavadero por tipo de vehículo.</returns>
        public double MostrarTotalFacturado(EVehiculos tipoVehiculo)
        {
            double precio = 0;

            foreach (Vehiculo vehiculo in this._vehiculos)
            {
                if (tipoVehiculo == EVehiculos.Auto && vehiculo is Auto)
                {
                    precio += _precioAuto;
                }
                else if (tipoVehiculo == EVehiculos.Camion && vehiculo is Camion)
                {
                    precio += _precioCamion;
                }
                else
                {
                    precio += _precioMoto;
                }
            }
            return precio;
        }

        /// <summary>
        /// Método estático para ordenar vehículos por patente.
        /// </summary>
        /// <returns>0 si las patentes son iguales, 1 si la primera patente es mayor, -1 en otro caso.</returns>
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Patente, vehiculo2.Patente);
        }

        /// <summary>
        /// Método de instancia para ordenar vehículos por marca.
        /// </summary>
        /// <returns>0 si las marcas son iguales, 1 si la primera marca es mayor, -1 en otro caso.</returns>
        public static int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Marca.ToString(), vehiculo2.Marca.ToString());
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Sobrecarga del operador de igualdad para comparar un lavadero y un vehículo.
        /// </summary>
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            return lavadero._vehiculos.Contains(vehiculo);
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para comparar un lavadero y un vehículo.
        /// </summary>
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        /// <summary>
        /// Sobrecarga del operador '+' para agregar un vehículo al lavadero.
        /// </summary>
        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
                lavadero._vehiculos.Add(vehiculo);

            return lavadero;
        }

        /// <summary>
        /// Sobrecarga del operador '-' para quitar un vehículo del lavadero.
        /// </summary>
        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
                lavadero._vehiculos.Remove(vehiculo);
            return lavadero;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Representa un estante que contiene productos.
    /// </summary>
    [XmlInclude(typeof(Harina))]
    [XmlInclude(typeof(Jugo))]
    [XmlInclude(typeof(Gaseosa))]
    [XmlInclude(typeof(Galletita))]
    public class Estante
    {
        #region Atributos
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el valor total de todos los productos en el estante.
        /// </summary>
        public float ValorEstanteTotal
        {
            get
            {
                return GetValorEstante();
            }
            set
            {
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Producto> Productos
        {
            get
            {
                return _productos;
            }
            set
            {
                _productos = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public sbyte Capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de la clase Estante.
        /// </summary>
        private Estante()
        {
            _productos = new List<Producto>();
        }

        /// <summary>
        /// Constructor público de la clase Estante que recibe la capacidad como parámetro.
        /// </summary>
        /// <param name="capacidad">La capacidad máxima de productos que puede contener el estante.</param>
        public Estante(sbyte capacidad)
            : this()
        {
            _capacidad = capacidad;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Obtiene la lista de productos en el estante.
        /// </summary>
        /// <returns>Lista de productos en el estante.</returns>
        public List<Producto> GetProductos()
        {
            return _productos;
        }

        /// <summary>
        /// Muestra los detalles del estante y sus productos.
        /// </summary>
        /// <param name="e">El estante a mostrar.</param>
        /// <returns>Una cadena que representa los detalles del estante.</returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad: {estante._capacidad}\n");

            if(estante._productos.Count > 0)
            {
                foreach (Producto item in estante._productos)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            else
            {
                sb.AppendLine("El estante no posee productos.");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Obtiene el valor total de los productos del tipo especificado en el estante.
        /// </summary>
        /// <param name="tipoProducto">El tipo de producto del cual se desea obtener el valor total.</param>
        /// <returns>El valor total de los productos del tipo especificado.</returns>
        public float GetValorEstante(ETipoProducto tipoProducto)
        {
            float valorTotal = 0;
            foreach (Producto producto in _productos)
            {
                if(tipoProducto == ETipoProducto.Todos)
                {
                    valorTotal += producto.CalcularCostoDeProduccion;
                }
                else if (producto.GetType().Name == tipoProducto.ToString())
                {
                    valorTotal += producto.CalcularCostoDeProduccion;
                }
            }

            return valorTotal;

            //float retorno = 0;

            //foreach (Producto item in _productos)
            //{
            //    switch (tipoProducto)
            //    {
            //        case ETipoProducto.Galletita:
            //            if (item is Galletita)
            //            {
            //                retorno = item.CalcularCostoDeProduccion;
            //            }
            //            break;

            //        case ETipoProducto.Gaseosa:
            //            if (item is Gaseosa)
            //            {
            //                retorno = item.CalcularCostoDeProduccion;
            //            }
            //            break;

            //        case ETipoProducto.Jugo:
            //            if (item is Jugo)
            //            {
            //                retorno = item.CalcularCostoDeProduccion;
            //            }
            //            break;

            //        case ETipoProducto.Harina:
            //            if (item is Harina)
            //            {
            //                retorno = item.CalcularCostoDeProduccion;
            //            }
            //            break;

            //        case ETipoProducto.Todos:
            //            retorno = item.CalcularCostoDeProduccion;
            //            break;
            //    }
            //}
            //return retorno;
        }

        /// <summary>
        /// Obtiene el valor total de todos los productos en el estante.
        /// </summary>
        /// <returns>El valor total de todos los productos en el estante.</returns>
        private float GetValorEstante()
        {
            return GetValorEstante(ETipoProducto.Todos);
        }

        /// <summary>
        /// Guarda la información del estante y sus productos en un archivo de texto.
        /// </summary>
        /// <param name="e">El estante a guardar.</param>
        /// <param name="rutaArchivo">La ruta del archivo donde se guardará la información.</param>
        public static void GuardarEstante(Estante estante, string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                using (FileStream fs = File.Create(rutaArchivo))
                {
                    fs.Close();
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                streamWriter.WriteLine(MostrarEstante(estante));
            }
        }

        /// <summary>
        /// Serializa la información del estante y sus productos en un archivo XML.
        /// </summary>
        /// <param name="e">El estante a serializar.</param>
        /// <param name="rutaArchivo">La ruta del archivo XML donde se guardará la información.</param>
        public static void SerializarEstante(Estante estante, string rutaArchivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Estante));
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                xmlSerializer.Serialize(streamWriter, estante);
            }
        }

        /// <summary>
        /// Deserializa la información de un estante y sus productos desde un archivo XML.
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo XML que contiene la información del estante.</param>
        /// <returns>El estante deserializado.</returns>
        public static Estante DeserializarEstante(string rutaArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Estante));
            using (StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                return (Estante)serializer.Deserialize(streamReader);
            }
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador de igualdad para determinar si un producto está en el estante.
        /// </summary>
        public static bool operator ==(Estante estante, Producto producto)
        {
            return estante._productos.Contains(producto);
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para determinar si un producto no está en el estante.
        /// </summary>
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        /// <summary>
        /// Sobrecarga del operador de adición para agregar un producto al estante.
        /// </summary>
        public static bool operator +(Estante estante, Producto producto)
        {
            bool retorno = false;

            if (estante != producto && estante._productos.Count < estante._capacidad)
            {
                estante._productos.Add(producto);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador de substracción para quitar un producto del estante.
        /// </summary>
        public static Estante operator -(Estante estante, Producto producto)
        {
            if (estante == producto)
            {
                estante._productos.Remove(producto);
            }

            return estante;
        }

        /// <summary>
        /// Sobrecarga del operador de substracción para quitar productos de un tipo específico del estante.
        /// </summary>
        public static Estante operator -(Estante estante, ETipoProducto tipoProducto)
        {
            //List<Producto> productosEliminados = new List<Producto>();

            //foreach (Producto producto in estante._productos)
            //{
            //    if (producto.GetType().Name == tipoProducto.ToString())
            //    {
            //        productosEliminados.Add(producto);
            //    }
            //}

            //foreach (var producto in productosEliminados)
            //{
            //    estante._productos.Remove(producto);
            //}

            if (tipoProducto == ETipoProducto.Todos)
            {
                estante._productos.Clear();
            }
            else
            {
                for (int i = 0; i < estante._productos.Count; i++)
                {
                    if (tipoProducto == ETipoProducto.Galletita && estante._productos[i] is Galletita)
                    {
                        estante._productos.RemoveAt(i);
                        i--;
                    }
                    else if (tipoProducto == ETipoProducto.Gaseosa && estante._productos[i] is Gaseosa)
                    {
                        estante._productos.RemoveAt(i);
                        i--;
                    }
                    else if (tipoProducto == ETipoProducto.Harina && estante._productos[i] is Harina)
                    {
                        estante._productos.RemoveAt(i);
                        i--;
                    }
                    else if (tipoProducto == ETipoProducto.Jugo && estante._productos[i] is Jugo)
                    {
                        estante._productos.RemoveAt(i);
                        i--;
                    }
                }
            }
            return estante;
        }
        #endregion
    }
}

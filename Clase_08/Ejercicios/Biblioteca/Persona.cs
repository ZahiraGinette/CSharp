using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private int edad;
        private EGenero genero;
        private string direccion;
        private string pais;
        #endregion

        #region Propiedades
        public string Direccion { get { return direccion; } set { direccion = value; } }

        public int Edad {  get { return edad; } set {  edad = value; } }

        public EGenero Genero { get {  return genero; } set {  genero = value; } }

        public string Nombre { get {  return nombre; } set {  nombre = value; } }

        public string Pais { get {  return pais; } set {  pais = value; } }
        #endregion

        #region Constructores
        public Persona(string nombre, int edad, EGenero genero, string direccion, string pais)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.direccion = direccion;
            this.pais = pais;
        }
        #endregion

        #region Métodos

        #endregion

        #region Sobrecarga de operadores

        #endregion
    }
}

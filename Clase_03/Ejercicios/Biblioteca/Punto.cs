using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /// <summary>
    /// Representa un punto en un plano cartesiano con coordenadas (x, y).
    /// </summary>
    public class Punto
    {
        #region Atributos
        private int x;
        private int y;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de la clase Punto con las coordenadas especificadas.
        /// </summary>
        /// <param name="x">Coordenada X del punto.</param>
        /// <param name="y">Coordenada Y del punto.</param>
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Obtiene la coordenada X del punto.
        /// </summary>
        public int GetX() 
        { 
            return x; 
        }

        /// <summary>
        /// Obtiene la coordenada Y del punto.
        /// </summary>
        public int GetY() 
        { 
            return y; 
        }

        #endregion
    }
}

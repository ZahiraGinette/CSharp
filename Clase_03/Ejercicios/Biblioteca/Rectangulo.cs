using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /// <summary>
    /// Representa un rectángulo en un plano cartesiano.
    /// </summary>
    public class Rectangulo
    {
        #region Atirbutos
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una nueva instancia de la clase Rectangulo a partir de dos vértices opuestos.
        /// </summary>
        /// <param name="vertice1">Primer vértice del rectángulo.</param>
        /// <param name="vertice3">Tercer vértice del rectángulo.</param>
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Calcula el área del rectángulo.
        /// </summary>
        /// <returns>El área del rectángulo.</returns>
        public float Area()
        {
            if (area == 0)
            {
                float baseRectangulo = Math.Abs(vertice2.GetX() - vertice1.GetX());
                float alturaRectangulo = Math.Abs(vertice2.GetY() - vertice3.GetY());
                area = baseRectangulo * alturaRectangulo;
            }

            return area;
        }

        /// <summary>
        /// Calcula el perímetro del rectángulo.
        /// </summary>
        /// <returns>El perímetro del rectángulo.</returns>
        public float Perimetro()
        {
            if (perimetro == 0)
            {
                float baseRectangulo = Math.Abs(vertice2.GetX() - vertice1.GetX());
                float alturaRectangulo = Math.Abs(vertice2.GetY() - vertice3.GetY());
                perimetro = (baseRectangulo + alturaRectangulo) * 2;
            }
            return perimetro;
        }
        #endregion
    }
}

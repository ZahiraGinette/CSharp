using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02.First
{
    [TestClass]
    public class CalculadoraEstadisticaTests
    {
        private CalculadoraEstadistica calculadora;

        public CalculadoraEstadisticaTests()
        {
            calculadora = new CalculadoraEstadistica();
        }

        [TestMethod]
        public void CalcularPromedio_ListaNoVacia_ResultadoCorrecto()
        {
            // Arrange
            List<double> numeros = new List<double> { 2, 4, 6, 8, 10 };

            // Act
            double resultado = calculadora.CalcularPromedio(numeros);

            // Assert
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void CalcularSuma_ListaNoNula_ResultadoCorrecto()
        {
            // Arrange
            List<double> numeros = new List<double> { 2, 4, 6, 8, 10 };

            // Act
            double resultado = calculadora.CalcularSuma(numeros);

            // Assert
            Assert.AreEqual(30, resultado);
        }

        [TestMethod]
        public void CalcularMediana_ListaNoVacia_ResultadoCorrecto()
        {
            // Arrange
            List<double> numeros = new List<double> { 2, 4, 6, 8, 10 };

            // Act
            double resultado = calculadora.CalcularMediana(numeros);

            // Assert
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void CalcularPromedio_ListaVacia_LanzaExcepcion()
        {
            // Arrange
            List<double> numeros = new List<double>();

            // Act
            try
            {
                calculadora.CalcularPromedio(numeros);
                Assert.Fail("Se esperaba una excepción de tipo ArgumentException.");
            }
            catch (ArgumentException ex)
            {
                // Assert
                StringAssert.Contains(ex.Message, "La lista de números no puede estar vacía");
            }
        }

        [TestMethod]
        public void CalcularSuma_ListaNula_LanzaExcepcion()
        {
            // Arrange
            List<double> numeros = null;

            // Act
            try
            {
                calculadora.CalcularSuma(numeros);
                Assert.Fail("Se esperaba una excepción de tipo ArgumentNullException.");
            }
            catch (ArgumentNullException ex)
            {
                // Assert
                StringAssert.Contains(ex.Message, "La lista de números no puede ser nula");
            }
        }

        [TestMethod]
        public void CalcularMediana_ListaVacia_LanzaExcepcion()
        {
            // Arrange
            List<double> numeros = new List<double>();

            // Act
            try
            {
                calculadora.CalcularMediana(numeros);
                Assert.Fail("Se esperaba una excepción de tipo ArgumentException.");
            }
            catch (ArgumentException ex)
            {
                // Assert
                StringAssert.Contains(ex.Message, "La lista de números no puede estar vacía");
            }
        }
    }
}

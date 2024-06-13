using _01.Creacion_Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01.Creacion_prueba_unitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumaNumerosPositivos()
        {
            // Arrange
            int numeroUno = 3;
            int numeroDos = 3;
            Calculadora calculadora = new Calculadora();

            // Act
            int resultado = calculadora.Sumar(numeroUno, numeroDos);

            // Assert
            Assert.AreEqual(6, resultado, "La suma de 3 y 3 debería ser 6");

        }

        //[TestMethod]
        //public void SumaNumerosPositivosError()
        //{
        //    // Arrange
        //    int numero1 = 5;
        //    int numero2 = 5;
        //    var calculadora = new Calculadora();

        //    // Act
        //    int resultado = calculadora.Sumar(numero1, numero2);

        //    // Assert
        //    Assert.AreEqual(8, resultado, "La suma de 5 y 3 debería ser 8");

        //}

        [TestMethod]
        public void SumaNumerosNegativos()
        {
            // Arrange
            int numero1 = -5;
            int numero2 = -3;
            var calculadora = new Calculadora();

            // Act
            int resultado = calculadora.Sumar(numero1, numero2);

            // Assert
            Assert.AreEqual(-8, resultado, "La suma de -5 y -3 debería ser -8");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Dividir_PorCero_LanzaExcepcion()
        {
            // Arrange
            double dividendo = 10;
            double divisor = 0;
            var calculadora = new Calculadora();

            // Act
            calculadora.Dividir(dividendo, divisor);

            // Assert (el assert es manejado por ExpectedException)
        }


        [TestMethod]
        [Timeout(2000)]
        public void UnTest()
        {
            // ...
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void OtroTest()
        {
            // ...
        }
    }
}

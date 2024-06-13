using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03.FizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        private Calculadora calculadora;

        [TestInitialize]
        public void Setup()
        {
            calculadora = new Calculadora();
        }

        [TestMethod]
        public void JuegoFizzBuzz_NumeroDivisibleSoloPor3_RetornaFizz()
        {
            // Arrange
            int numero = 9;

            // Act
            string resultado = calculadora.JuegoFizzBuzz(numero);

            // Assert
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void JuegoFizzBuzz_NumeroDivisibleSoloPor5_RetornaBuzz()
        {
            // Arrange
            int numero = 10;

            // Act
            string resultado = calculadora.JuegoFizzBuzz(numero);

            // Assert
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void JuegoFizzBuzz_NumeroDivisiblePor3Y5_RetornaFizzBuzz()
        {
            // Arrange
            int numero = 15;

            // Act
            string resultado = calculadora.JuegoFizzBuzz(numero);

            // Assert
            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void JuegoFizzBuzz_NumeroNoDivisiblePor3Ni5_RetornaNumeroComoString()
        {
            // Arrange
            int numero = 7;

            // Act
            string resultado = calculadora.JuegoFizzBuzz(numero);

            // Assert
            Assert.AreEqual("7", resultado);
        }
    }
}

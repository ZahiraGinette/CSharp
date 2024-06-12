using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitariosEjercicios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_DeberiaDevolverCeroConStringVacio()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "";

            // Act
            int resultado = calculadora.Add(numeros);

            // Assert
            Assert.Equals(0, resultado);
        }

        [TestMethod]
        public void Add_DeberiaDevolverElMismoNumeroConUnNumero()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "5";

            // Act
            int resultado = calculadora.Add(numeros);

            // Assert
            Assert.Equals(5, resultado);
        }

        [TestMethod]
        public void Add_DeberiaDevolverSumaConDosNumerosSeparadosPorComa()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "5,7";

            // Act
            int resultado = calculadora.Add(numeros);

            // Assert
            Assert.Equals(12, resultado);
        }

        [TestMethod]
        public void Add_DeberiaPermitirCantidadDesconocidaDeNumeros()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "5,7,8,10";

            // Act
            int resultado = calculadora.Add(numeros);

            // Assert
            Assert.Equals(30, resultado);
        }

        [TestMethod]
        public void Add_DeberiaPermitirSaltoDeLineaEntreNumeros()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "1\n2,3";

            // Act
            int resultado = calculadora.Add(numeros);

            // Assert
            Assert.Equals(6, resultado);
        }

        [TestMethod]
        public void Add_DeberiaSoportarDiferentesDelimitadores()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "//;\n1;2;3";

            // Act
            int resultado = calculadora.Add(numeros);

            // Assert
            Assert.Equals(6, resultado);
        }

        [TestMethod]
        public void Add_DeberiaLanzarExcepcionConNumerosNegativos()
        {
            // Arrange
            CalculadoraString calculadora = new CalculadoraString();
            string numeros = "1,-2,3";

            // Act y Assert
            Assert.ThrowsException<NegativoNoPermitidoException>(() => calculadora.Add(numeros));
        }
    }
}

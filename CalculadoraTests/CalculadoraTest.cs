using Xunit;
using CalculadoraConsole.Services;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void DeveSomarDoisNumeros()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Somar(5, 3);

            // Assert
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void DeveSubtrairDoisNumeros()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Subtrair(10, 4);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveMultiplicarDoisNumeros()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Multiplicar(6, 4);

            // Assert
            Assert.Equal(24, resultado);
        }

        [Fact]
        public void DeveDividirDoisNumeros()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Dividir(20, 4);

            // Assert
            Assert.Equal(5, resultado);
        }

        // Cenários de teste para números decimais
        [Fact]
        public void DeveSomarDoisNumerosDecimais()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Somar(5.5, 3.3);

            // Assert
            Assert.Equal(8.8, resultado, 1);
        }

        [Fact]
        public void DeveSubtrairDoisNumerosDecimais()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Subtrair(10.5, 4.2);

            // Assert
            Assert.Equal(6.3, resultado, 1);
        }

        [Fact]
        public void DeveMultiplicarDoisNumerosDecimais()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Multiplicar(6.5, 4.2);

            // Assert
            Assert.Equal(27.3, resultado, 1);
        }

        [Fact]
        public void DeveDividirDoisNumerosDecimais()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double resultado = calculadora.Dividir(20.4, 4.2);

            // Assert
            Assert.Equal(4.8571, resultado, 4);  // Precisão de 4 casas decimais
        }

        // Cenário para divisão por zero
        [Fact]
        public void DeveLancarExcecaoAoDividirPorZero()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => calculadora.Dividir(20, 0));
        }
    }
}

using Xunit;
using CalculadoraConsole.Services;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        private Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void DeveSomarDoisNumeros()
        {
            double resultado = _calculadora.Somar(5, 3);
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void DeveSubtrairDoisNumeros()
        {
            double resultado = _calculadora.Subtrair(10, 4);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveMultiplicarDoisNumeros()
        {
            double resultado = _calculadora.Multiplicar(6, 4);
            Assert.Equal(24, resultado);
        }

        [Fact]
        public void DeveDividirDoisNumeros()
        {
            double resultado = _calculadora.Dividir(20, 4);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void DeveSomarDoisNumerosDecimais()
        {
            double resultado = _calculadora.Somar(5.5, 3.3);
            Assert.Equal(8.8, resultado, 1);
        }

        [Fact]
        public void DeveSubtrairDoisNumerosDecimais()
        {
            double resultado = _calculadora.Subtrair(10.5, 4.2);
            Assert.Equal(6.3, resultado, 1);
        }

        [Fact]
        public void DeveMultiplicarDoisNumerosDecimais()
        {
            double resultado = _calculadora.Multiplicar(6.5, 4.2);
            Assert.Equal(27.3, resultado, 1);
        }

        [Fact]
        public void DeveDividirDoisNumerosDecimais()
        {
            double resultado = _calculadora.Dividir(20.4, 4.2);
            Assert.Equal(4.8571, resultado, 4);
        }

        [Fact]
        public void DeveLancarExcecaoAoDividirPorZero()
        {
            Assert.Throws<System.DivideByZeroException>(() => _calculadora.Dividir(20, 0));
        }

        // Testes com números negativos
        [Fact]
        public void DeveSomarNumerosNegativos()
        {
            double resultado = _calculadora.Somar(-5, -3);
            Assert.Equal(-8, resultado);
        }

        [Fact]
        public void DeveSubtrairNumerosNegativos()
        {
            double resultado = _calculadora.Subtrair(-10, -4);
            Assert.Equal(-6, resultado);
        }

        [Fact]
        public void DeveMultiplicarNumerosNegativos()
        {
            double resultado = _calculadora.Multiplicar(-6, -4);
            Assert.Equal(24, resultado);
        }

        [Fact]
        public void DeveDividirNumerosNegativos()
        {
            double resultado = _calculadora.Dividir(-20, -4);
            Assert.Equal(5, resultado);
        }

        // Testes com zero
        [Fact]
        public void DeveSomarComZero()
        {
            double resultado = _calculadora.Somar(0, 5);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void DeveSubtrairComZero()
        {
            double resultado = _calculadora.Subtrair(0, 5);
            Assert.Equal(-5, resultado);
        }

        [Fact]
        public void DeveMultiplicarComZero()
        {
            double resultado = _calculadora.Multiplicar(0, 5);
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void DeveDividirNumeroPorZero()
        {
            Assert.Throws<System.DivideByZeroException>(() => _calculadora.Dividir(5, 0));
        }

        [Fact]
        public void DeveDividirZeroPorNumero()
        {
            double resultado = _calculadora.Dividir(0, 5);
            Assert.Equal(0, resultado);
        }

        // Testes de limites
        [Fact]
        public void DeveSomarLimiteMaximo()
        {
            double resultado = _calculadora.Somar(double.MaxValue, 1);
            Assert.Equal(double.MaxValue, resultado);
        }

        [Fact]
        public void DeveSubtrairLimiteMaximo()
        {
            double resultado = _calculadora.Subtrair(double.MaxValue, 1);
            Assert.Equal(double.MaxValue - 1, resultado);
        }

        [Fact]
        public void DeveMultiplicarLimiteMaximo()
        {
            double resultado = _calculadora.Multiplicar(double.MaxValue, 1);
            Assert.Equal(double.MaxValue, resultado);
        }

        [Fact]
        public void DeveDividirLimiteMaximo()
        {
            double resultado = _calculadora.Dividir(double.MaxValue, 1);
            Assert.Equal(double.MaxValue, resultado);
        }

        [Fact]
        public void DeveSomarLimiteMinimo()
        {
            double resultado = _calculadora.Somar(double.MinValue, -1);
            Assert.Equal(double.MinValue, resultado);
        }

        [Fact]
        public void DeveSubtrairLimiteMinimo()
        {
            double resultado = _calculadora.Subtrair(double.MinValue, -1);
            Assert.Equal(double.MinValue, resultado);
        }

        [Fact]
        public void DeveMultiplicarLimiteMinimo()
        {
            double resultado = _calculadora.Multiplicar(double.MinValue, 1);
            Assert.Equal(double.MinValue, resultado);
        }

        [Fact]
        public void DeveDividirLimiteMinimo()
        {
            double resultado = _calculadora.Dividir(double.MinValue, 1);
            Assert.Equal(double.MinValue, resultado);
        }
    }
}

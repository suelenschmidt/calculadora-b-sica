using System;
using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-2, 3, 1)]
        [InlineData(0, 0, 0)]
        public void Soma_DeveRetornarSomaCorreta(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculadora.Soma(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-2, -3, 1)]
        public void Subtracao_DeveRetornarDiferencaCorreta(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculadora.Subtracao(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(0, 3, 0)]
        [InlineData(5, 0, 0)]
        public void Multiplicacao_DeveRetornarProdutoCorreto(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculadora.Multiplicacao(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, 3, -2)]
        public void Divisao_DeveRetornarQuocienteCorreto(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculadora.Divisao(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Divisao_DividirPorZero_DeveLancarExcecao()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculadora.Divisao(10, 0));
        }
    }
}
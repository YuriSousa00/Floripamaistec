using CalculadoraTdd.Classes;
using Xunit;

namespace CalculadoraTddTest
{
    public class CalculadoraTest
    {
        [Fact]
        public void TestMetodoSomarInt()
        {
            int resultado = Calculadora.Somar(5, 5);

            int esperado = 10;

            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void TestMetodoSubtrairInt()
        {
            int resultado = Calculadora.Subtracao(10, 5);

            int esperado = 5;

            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void TestMetodoMultiplicacaoInt()
        {
            int resultado = Calculadora.Multiplicacao(10, 5);

            int esperado = 50;

            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void TestMetodoDivisaoInt()
        {
            int resultado = Calculadora.Divisao(10, 5);

            int esperado = 2;

            Assert.Equal(esperado, resultado);
        }
    }
}
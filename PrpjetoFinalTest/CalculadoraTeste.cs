using ProjetoFinal_Trilha_Net_Developer;

namespace ProjetoFinalTest
{
    public class CalculadoraTeste
    {
        [Theory]
        [InlineData(1, 3, 4)] // soma positiva
        [InlineData(-5, 5, 0)] // soma entre operandos negativos
        [InlineData(0, 0, 0)] // soma nula
        public void SomarTeste(int valor, int valor2, int resultadoEsperado)
        {
            //Act

            var resultado = Calculadora.somar(valor, valor2);
            //Assert

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(8, 2, 6)] // subtração positiva
        [InlineData(6, -3, 9)] // subtração entre operandos negativos
        [InlineData(0, 0, 0)] // subtração nula
        public void SubrairTeste(int valor, int valor2, int resultadoEsperado)
        {
            //Act

            var resultado = Calculadora.subtrair(valor, valor2);
            //Assert

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(4, 4, 16)] // multiplicação positiva
        [InlineData(3, -5, -15)] // multiplicação com multiplicador negativo
        [InlineData(1, 0, 0)] // multiplicação por zero
        public void MultiplicarTeste(int valor, int valor2, int resultadoEsperado)
        {
            //Act

            var resultado = Calculadora.multiplicar(valor, valor2);
            //Assert

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => Calculadora.dividir(12, 0)
                );
        }

        [Theory]
        [InlineData(25, 5, 5)] // divisão positiva
        [InlineData(-144, 2, -72)] // divisão com dividendo negativo
        public void DivisaoTeste(int valor, int valor2, int resultadoEsperado)
        {
            //Act

            var resultado = Calculadora.dividir(valor, valor2);
            //Assert

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void HistoricoTeste()
        {
            //Arrange

            string subtracaoModelo = "18 - 2 = 16";
            string multiplicacaoModelo = "7 * 3 = 21";
            string divisaoModelo = "64 / 2 = 32";
            //Act

            Calculadora.somar(5, 5);
            Calculadora.subtrair(18, 2);
            Calculadora.multiplicar(7, 3);
            Calculadora.dividir(64, 2);
            //Assert

            //historico não pode ser nulo
            Assert.NotNull(Calculadora.historico()); 

            //validando os retornos
            Assert.Equal(subtracaoModelo, Calculadora.historico().ElementAt(2));
            Assert.Equal(multiplicacaoModelo, Calculadora.historico().ElementAt(1));
            Assert.Equal(divisaoModelo, Calculadora.historico().ElementAt(0));

        }
    }
}
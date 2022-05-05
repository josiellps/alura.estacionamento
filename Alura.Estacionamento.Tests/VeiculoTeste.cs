using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste : IDisposable
    {
        private Veiculo veiculo;
        public ITestOutputHelper saidaConsoleTeste;

        public VeiculoTeste(ITestOutputHelper saidaConsoleTeste)
        {
            veiculo = new Veiculo();
            this.saidaConsoleTeste = saidaConsoleTeste;
            this.saidaConsoleTeste.WriteLine("Construtor invocado.");
        }


        [Fact]
        //[Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }

        [Fact]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrearComParametro10()
        {
            //Arrange
            //var veiculo = new Veiculo();

            //Act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste ainda n�o implementado")]
        public void ValidaNomeProprietario()
        {
            // Exemplo de utiliza��o do Skip
        }

        [Fact]
        public void AlterarDadosVeiculoDoProprioVeiculo()
        {
            //Arrange

            Patio estacionamento = new Patio();
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "Jos� Silva";
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "Jos� Silva";
            veiculoAlterado.Placa = "ZXC-8524";
            veiculoAlterado.Cor = "Preto"; //Alterado
            veiculoAlterado.Modelo = "Opala";

            //Act
            var alterado = estacionamento.AlteraDados(veiculoAlterado);

            //Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);

        }

        [Fact]
        public void ImprimeFichaDeInformacaoDoVeiculo()
        {
            //Arrange
            //var veiculo = new Veiculo();
            veiculo.Proprietario = "Andr� Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Preto";
            veiculo.Modelo = "Fusca";
            veiculo.Placa = "ZXC-8888";

            //Act
            string dadosveiculo = veiculo.ToString();

            //Assert
            Assert.Contains("Ficha do Ve�culo", dadosveiculo);
        }

        public void Dispose()
        {
            this.saidaConsoleTeste.WriteLine("Dispose invocado.");
        }
    }
}

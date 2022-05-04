using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class PatioTeste
    {
        [Fact]
        public void ValidaFaturamento()
        {
            //Arrange
            var veiculo = new Veiculo
            {
                Proprietario = "Josiel Lopes",
                Tipo = TipoVeiculo.Automovel,
                Cor = "Verde",
                Modelo = "Pick-Up",
                Placa = "ASD-9999"
            };

            var estacionamento = new Patio();
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Andre Silva", "ASD-9999", "preto", "Gol", TipoVeiculo.Automovel)]
        [InlineData("Josiel Lopes", "BVI-3086", "vermelho", "CG", TipoVeiculo.Automovel)]
        [InlineData("Viviane Peres", "FKA-2151", "preto", "Clio", TipoVeiculo.Automovel)]
        public void ValidaFaturamentoComVariosVeiculos(string proprietario, string placa, string cor, string modelo, TipoVeiculo tipoVeiculo)
        {
            //Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo
            {
                Proprietario = proprietario,
                Placa = placa,
                Cor = cor,
                Modelo = modelo,
                Tipo = tipoVeiculo
            };
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2,faturamento);
        }
    }
}

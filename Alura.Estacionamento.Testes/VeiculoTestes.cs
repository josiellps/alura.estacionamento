using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);
            
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
            
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Frear(10);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestarVeiculoTipoVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Tipo = Alura.Estacionamento.Modelos.TipoVeiculo.Automovel;

            //Assert
            Assert.Equal(Alura.Estacionamento.Modelos.TipoVeiculo.Automovel, veiculo.Tipo);
        }

        [Fact]
        public void TestarVeiculoTipoVeiculoFalha()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Tipo = Alura.Estacionamento.Modelos.TipoVeiculo.Automovel;

            //Assert
            Assert.NotEqual(Alura.Estacionamento.Modelos.TipoVeiculo.Motocicleta, veiculo.Tipo);
        }
    }
}

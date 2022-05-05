using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste
    {
   
        [Fact(DisplayName = "Teste n°1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }
         

        [Fact(DisplayName="Teste n°2")]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName="Teste n°3",Skip = "Teste ainda não implementado")]
        public void ValidaNomeProprietario()
        {
            // Exemplo de utilização do Skip
        }

        [Theory]
        [InlineData("Josiel Lopes","ASD-9874","preto","Gol")]
        public void LocalizaVeiculoNoPatio(string proprietario,string placa,string cor,string modelo)
        {
            //Arrage
            var estacionamento = new Patio();
            var veiculo = new Veiculo()
            {
                Proprietario = proprietario,
                Placa =   placa,
                Cor = cor,
                Modelo = modelo
            };
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            //Act
            var consultado = estacionamento.PesquisaVeiculo(veiculo.Placa);

            //Assert

            Assert.Equal(placa, consultado.Placa);
        }

        [Fact]
        public void DadosVeiculo()
        {
            //Arrange
            var carro = new Veiculo();
            carro.Proprietario = "Josiel Lopes";
            carro.Tipo = TipoVeiculo.Automovel;
            carro.Placa = "ZAP-7149";
            carro.Cor = "Verde";
            carro.Modelo = "Variante";

            //Act
            string dados = carro.ToString();

            //Assert
            Assert.Contains("Ficha do Veiculo:", dados);
        }
    }
}

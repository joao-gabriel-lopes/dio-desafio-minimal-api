using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Marca = "Mercedes";
        veiculo.Nome = "Classe C";
        veiculo.Ano = 2019;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Mercedes", veiculo.Marca);
        Assert.AreEqual("Classe C", veiculo.Nome);
        Assert.AreEqual(2019, veiculo.Ano);

    }
}

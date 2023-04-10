using validadorDeNumeros.Classes;
using Xunit;

namespace ValidadorDeNumerosTest;

public class ValidadorDeNumerosTest
{
    [Fact]
    public void TesteEhNumeroPrimo()
    {
        bool resultado = ValidadorDeNumeros.EhNumeroPrimo(17);

        Assert.True(resultado);
    }

    [Fact]
    public void TesteParOuImpar()
    {
        string resultado = ValidadorDeNumeros.ParOuImpar(17);

        string esperado = "Impar";

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void TesteEhDivisivelPor()
    {
        bool resultado = ValidadorDeNumeros.EhDivisivelPor(15, 5);

        Assert.True(resultado);
    }
}
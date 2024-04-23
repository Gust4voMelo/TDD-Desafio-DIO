using NewTalents;

namespace TesteNewTalents;


public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "23/04/2024";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoCalculadora = calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoCalculadora = calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoCalculadora = calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(9, 5, 4)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        var resultadoCalculadora = calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TestName()
    {
        Calculadora calc = construirClasse();

        calc.Somar(1,2);
        calc.Somar(3,4);
        calc.Somar(5,6);
        calc.Somar(7,8);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
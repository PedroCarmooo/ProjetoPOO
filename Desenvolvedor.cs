// Herança: Desenvolvedor herda de Funcionario e implementa CalcularCustoHora.
public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome)
    {
        Cargo = "Desenvolvedor";
    }

    public override double CalcularCustoHora() => 100.0;
}

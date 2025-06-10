public class Gerente : Funcionario
{
    public Gerente(string nome) : base(nome)
    {
        Cargo = "Gerente";
    }

    public override double CalcularCustoHora() => 150.0;
}

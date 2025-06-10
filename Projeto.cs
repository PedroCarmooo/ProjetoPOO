public class Projeto
{
    public string Nome { get; private set; }
    public List<Alocacao> Alocacoes { get; private set; } = new List<Alocacao>();

    public Projeto(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlocacao(Funcionario funcionario, int horas)
    {
        if (horas <= 0)
            throw new ArgumentException("Horas devem ser maiores que zero.");

        Alocacoes.Add(new Alocacao(funcionario, horas));
    }

    public double CalcularCustoTotal()
    {
        return Alocacoes.Sum(a => a.Horas * a.Funcionario.CalcularCustoHora());
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Projeto: {Nome}");
        foreach (var aloc in Alocacoes)
        {
            Console.WriteLine($"- {aloc.Funcionario.Cargo}: {aloc.Funcionario.Nome} ({aloc.Horas}h)");
        }
        Console.WriteLine($"Custo total: R${CalcularCustoTotal():F2}");
    }
}

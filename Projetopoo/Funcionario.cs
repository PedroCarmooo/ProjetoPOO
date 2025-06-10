// Abstração: classe genérica para representar qualquer tipo de funcionário.
// Encapsulamento: propriedades públicas com comportamento comum a todos.
public abstract class Funcionario
{
    public string Nome { get; private set; }
    public string Cargo { get; protected set; }

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    // Polimorfismo: método abstrato que será implementado de forma diferente por subclasses.
    public abstract double CalcularCustoHora();
}

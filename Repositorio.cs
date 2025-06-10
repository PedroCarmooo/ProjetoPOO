// Simula uma camada de dados local (como um repositório em memória).
// Boa prática para separar lógica de armazenamento da lógica de negócios (coesão).
public class Repositorio
{
    public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();
    public List<Projeto> Projetos { get; private set; } = new List<Projeto>();

    public void AdicionarFuncionario(Funcionario f) => Funcionarios.Add(f);
    public void AdicionarProjeto(Projeto p) => Projetos.Add(p);

    public Funcionario? BuscarFuncionario(string nome)
        => Funcionarios.FirstOrDefault(f => f.Nome.ToLower() == nome.ToLower());

    public Projeto? BuscarProjeto(string nome)
        => Projetos.FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());
}

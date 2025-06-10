internal class Program
{
    static Repositorio repo = new Repositorio();

    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Cadastrar Projeto");
            Console.WriteLine("3 - Alocar Funcionário a Projeto");
            Console.WriteLine("4 - Exibir Projetos");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CadastrarFuncionario(); break;
                case "2": CadastrarProjeto(); break;
                case "3": AlocarFuncionario(); break;
                case "4": ExibirProjetos(); break;
                case "5": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    static void CadastrarFuncionario()
    {
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        Console.Write("Cargo (1 - Desenvolvedor | 2 - Gerente): ");
        var cargo = Console.ReadLine();

        Funcionario f = cargo == "1" ? new Desenvolvedor(nome) : new Gerente(nome);
        repo.AdicionarFuncionario(f);
        Console.WriteLine("Funcionário cadastrado!");
    }

    static void CadastrarProjeto()
    {
        Console.Write("Nome do projeto: ");
        var nome = Console.ReadLine();
        repo.AdicionarProjeto(new Projeto(nome));
        Console.WriteLine("Projeto cadastrado!");
    }

    static void AlocarFuncionario()
    {
        Console.Write("Nome do projeto: ");
        var nomeProjeto = Console.ReadLine();
        var projeto = repo.BuscarProjeto(nomeProjeto);
        if (projeto == null) { Console.WriteLine("Projeto não encontrado."); return; }

        Console.Write("Nome do funcionário: ");
        var nomeFuncionario = Console.ReadLine();
        var funcionario = repo.BuscarFuncionario(nomeFuncionario);
        if (funcionario == null) { Console.WriteLine("Funcionário não encontrado."); return; }

        Console.Write("Horas alocadas: ");
        int horas = int.Parse(Console.ReadLine());

        projeto.AdicionarAlocacao(funcionario, horas);
        Console.WriteLine("Alocação realizada!");
    }

    static void ExibirProjetos()
    {
        foreach (var p in repo.Projetos)
        {
            p.ExibirDetalhes();
            Console.WriteLine("-----------");
        }
    }
}

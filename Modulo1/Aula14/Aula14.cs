
using Aula14.ClassOO;
using TarefasAulaOO.Aula14;

//// Static

//Sistema.DataInicializaçâo = DateTime.Now;

//Console.WriteLine(Pessoa.Contagem);

//new Pessoa();
//new Pessoa();
//new Pessoa();
//new Pessoa("João").Apresentar();
//Pessoa.ApresentarPessoaStatic(new Pessoa("Joãozinho"));

//new Pessoa();
//new Pessoa();
//new Pessoa();

//Console.WriteLine(Pessoa.Contagem);

//Console.ReadLine();
//Console.WriteLine($"Data de inicialização do sistema: {Sistema.DataInicializaçâo.ToString("dd/MM/yyyy HH:mm")}");



// Maos Na Massa -----------------------------------------------------

int opcao = 0;

do
{
    Console.Clear();
    Console.WriteLine("\n-----------------------------------------------------------\n");

    Console.WriteLine("Olá, seja bem-vindo!\n");
    Console.WriteLine("1 - Atividade 1");
    Console.WriteLine("2 - Atividade 2");
    Console.WriteLine("3 - Sair");

    Console.WriteLine("\n-----------------------------------------------------------\n");

    Console.WriteLine("\nQual rotina deseja executar? (Digite o número da atividade)\n");

    var escolha = Console.ReadLine();
    bool escolhaValida = int.TryParse(escolha, out opcao);

    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nTarefa Produtos:\n");
            Produto2.ExecutarTarefa1();
            break;
        case 2:
            Console.WriteLine("\nTarefa Conta Bancária:\n");
            ContaBancaria2.ExecutarTarefa2();
            break;
        default:
            break;
    }
} while (opcao != 3);
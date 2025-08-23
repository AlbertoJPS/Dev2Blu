using TarefasAulaOO.Aula13;

int opcao = 0;

do
{
    Console.Clear();
    Console.WriteLine("\n--- Menu Principal ---");
    Console.WriteLine("1 - Cadastrar Aluno");
    Console.WriteLine("2 - Cadastrar Produto");
    Console.WriteLine("3 - Criar Conta Bancária");
    Console.WriteLine("4 - Sair");
    Console.Write("\nEscolha uma opção: ");

    var entrada = Console.ReadLine();
    int.TryParse(entrada, out opcao);
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastro de Aluno:");
            Console.Write("Nome: ");
            string nomeAluno = Console.ReadLine();

            Console.Write("Idade: ");
            bool idadeOk = int.TryParse(Console.ReadLine(), out int idade);
            if (!idadeOk)
            {
                Console.WriteLine("Idade inválida.");
                break;
            }

            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();

            var aluno = new Aluno(nomeAluno, idade, matricula);
            aluno.ExibirInfo();
            aluno.CalcularIdadeEmMeses();
            break;

        case 2:
            Console.WriteLine("Cadastro de Produto:");
            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Preço: ");
            bool precoOk = double.TryParse(Console.ReadLine(), out double preco);
            if (!precoOk)
            {
                Console.WriteLine("Preço inválido.");
                break;
            }

            Console.Write("Quantidade em Estoque: ");
            bool qtdOk = int.TryParse(Console.ReadLine(), out int estoque);
            if (!qtdOk)
            {
                Console.WriteLine("Quantidade inválida.");
                break;
            }

            var produto = new Produto(nomeProduto, preco, estoque);
            produto.ExibirInfo();

            Console.Write("\nAtualizar Estoque? Digite nova quantidade: ");
            bool novaQtdOk = int.TryParse(Console.ReadLine(), out int novaQtd);
            if (!novaQtdOk)
            {
                Console.WriteLine("Quantidade inválida.");
                break;
            }
            produto.AtualizarEstoque(novaQtd);
            break;

        case 3:
            Console.WriteLine("Criação de Conta Bancária:");
            Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();

            Console.Write("Saldo inicial: R$ ");
            bool saldoOk = decimal.TryParse(Console.ReadLine(), out decimal saldoInicial);
            if (!saldoOk)
            {
                Console.WriteLine("Saldo inválido.");
                break;
            }

            var conta = new ContaBancaria(titular, saldoInicial);
            conta.ExibirSaldo();

            Console.Write("\nDigite valor para depósito: R$ ");
            bool depositoOk = decimal.TryParse(Console.ReadLine(), out decimal deposito);
            if (depositoOk)
                conta.Depositar(deposito);
            else
                Console.WriteLine("Valor de depósito inválido.");

            Console.Write("Digite valor para saque: R$ ");
            bool saqueOk = decimal.TryParse(Console.ReadLine(), out decimal saque);
            if (saqueOk)
                conta.Sacar(saque);
            else
                Console.WriteLine("Valor de saque inválido.");

            conta.ExibirSaldo();
            break;

        case 4:
            Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (opcao != 4)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while (opcao != 4);

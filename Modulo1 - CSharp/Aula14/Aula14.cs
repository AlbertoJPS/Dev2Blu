
using Aula14.ClassOO;
using System.Globalization;
using System.Text;
using Aula15.Enums;
using TarefasAulaOO;

//// Static Elements -----------------------------------------------------------------------------------------------

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

////Aluno

//var aluno1 = new Aluno("Julio", 22, new DateTime(2003, 5, 22), "21200741");
//var aluno2 = new Aluno("Wallace", 22, new DateTime(2003, 3, 4));

//aluno1.CalcularIdadeEmMeses();
//aluno2.CalcularIdadeEmMeses();

//aluno1.ExibirInfo();
//aluno2.ExibirInfo();

////Banco

//var contaJulio = new ContaBancaria("Julio", 457.27m);
//var contaTioZe = new ContaBancaria("Zé");

//contaJulio.Depositar(-56);
//contaJulio.Sacar(0.27m);
//contaJulio.Sacar(500);
//contaJulio.Depositar(100.45m);
//contaTioZe.Depositar(50);
//contaTioZe.ExibirSaldo();
//contaJulio.ExibirSaldo();
//Console.WriteLine($"Que legal! Temos {ContaBancaria.ContagemContas} cadastradas em nosso banco!");

////Produto

//List<Produto> produtos = new List<Produto>();
//bool importado = false;
//string nome;
//double preco;
//int quantidade;
//string verificacao = "";
//int numero;
//Console.Write("Quantos produtos você deseja cadastrar no estoque? ");
//while (!int.TryParse(Console.ReadLine(), out numero))
//{
//    Console.WriteLine("Entrada inválida! Tente novamente...");
//}
//for (int i = 0; i < numero; i++)
//{
//    Console.Write("Digite o nome do produto: ");
//    nome = Console.ReadLine();
//    Console.Write("Digite o valor do produto: ");
//    while (!double.TryParse(Console.ReadLine(), out preco))
//    {
//        Console.WriteLine("Entrada inválida! Tente novamente...");
//    }
//    Console.Write("Digite a quantidade em estoque do produto: ");
//    while (!int.TryParse(Console.ReadLine(), out quantidade))
//    {
//        Console.WriteLine("Entrada inválida! Tente novamente...");
//    }
//    Console.WriteLine("Seu produto é importado?(S ou N) ");
//    while (verificacao != "S" && verificacao != "N")
//    {
//        verificacao = Console.ReadLine();
//        if (verificacao == "S")
//        {
//            importado = true;
//        }
//        else if (verificacao == "N")
//        {
//            importado = false;
//        }
//        else
//        {
//            Console.WriteLine("Resposta inválida! Tente novamente...");
//        }
//    }
//    verificacao = "";
//    if (quantidade == 0)
//    {
//        produtos.Add(new Produto(nome, preco, importado));
//    }
//    else
//    {
//        produtos.Add(new Produto(nome, preco, quantidade, importado));
//    }
//}
//int controle = 0;
//while (controle != 5)
//{
//    Console.WriteLine("Menu do Estoque. Selecione o que deseja fazer");
//    Console.WriteLine("1 - Adicionar ao Estoque");
//    Console.WriteLine("2 - Retirar do Estoque");
//    Console.WriteLine("3 - Exibir o que tem no estoque");
//    //Console.WriteLine("4 - Exibir valor de um produto em Real ou Dólar!");
//    Console.WriteLine("5 - Sair");
//    int.TryParse(Console.ReadLine(), out controle);
//    switch (controle)
//    {
//        case 1:
//            Console.Write("Diga o produto a ser adicionado: ");
//            nome = Console.ReadLine();
//            var produtoAdicionar = produtos.FirstOrDefault(p => p.Nome == nome);
//            if (produtoAdicionar != null)
//            {
//                Console.Write("Digite a quantidade a ser adicionada: ");
//                while (!int.TryParse(Console.ReadLine(), out quantidade))
//                {
//                    Console.WriteLine("Entrada invalida! Tente novamente...");
//                }
//                produtoAdicionar.AdicionarEstoque(quantidade);
//            }
//            else
//            {
//                Console.WriteLine("Produto não encontrado no estoque!");
//            }
//            break;
//        case 2:
//            Console.Write("Diga o produto a ser retirado: ");
//            nome = Console.ReadLine();
//            var produtoRetirar = produtos.FirstOrDefault(p => p.Nome == nome);
//            if (produtoRetirar != null)
//            {
//                Console.Write("Digite a quantidade a ser retirada: ");
//                while (!int.TryParse(Console.ReadLine(), out quantidade))
//                {
//                    Console.WriteLine("Entrada invalida! Tente novamente...");
//                }
//                produtoRetirar.RetirarEstoque(quantidade);
//            }
//            else
//            {
//                Console.WriteLine("Produto não encontrado no estoque!");
//            }
//            break;
//        case 3:
//            foreach (var produto in produtos)
//            {
//                produto.ExibirInfoEstoque();
//            }
//            break;
//        // case 4:
//        //     Console.Write("Diga o nome do produto a ser analisado: ");
//        //     nome = Console.ReadLine();
//        //     var produtoAnalisado = produtos.FirstOrDefault(p => p.Nome == nome);
//        //     if (produtoAnalisado != null)
//        //     {
//        //         string precoFormatado = Produto.ValorEmPadraoMonetario(produtoAnalisado.Preco, produtoAnalisado.Importado);
//        //         Console.WriteLine($"Preço do produto {produtoAnalisado.Nome}: {precoFormatado}");
//        //     }
//        //     else
//        //     {
//        //         Console.WriteLine("Produto não encontrado no estoque!");
//        //     }
//        //     break;
//        case 5:
//            Console.WriteLine("Fechando o estoque...");
//            break;
//        default:
//            Console.WriteLine("Opção inválida!");
//            break;
//    }

//}
//Console.WriteLine("Estoque fechado!");

//---------------------------------------------------------------------------------------------------------
//Maos Na Massa -------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------

List<Aluno> listaAlunos = new();
List <Produto> listaProdutos = new();
List<ContaBancaria> listaContas = new();

MenuPrincipal();

void MenuPrincipal()
{
    int opcaoPrincipal;

    do
    {
        Console.Clear();
        Console.WriteLine("\n=========================================");
        Console.WriteLine("\nOlá!! Abaixo esá a lista de tarefas de Aula");
        Console.WriteLine("\n============ Menu  Principal ============\n");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1 - Gerenciar Alunos");
        Console.WriteLine("2 - Gerenciar Produtos");
        Console.WriteLine("3 - Gerenciar Contas Bancárias");
        Console.WriteLine("4 - Sair");
        Console.ResetColor();
        Console.WriteLine("\n=========================================");
        Console.Write("\nEscolha uma opção: ");

        string entrada = Console.ReadLine();
        bool valido = int.TryParse(entrada, out opcaoPrincipal);
        Console.Clear();

        if (!valido) continue;

        switch (opcaoPrincipal)
        {
            case 1:
                MenuAlunos();
                break;
            case 2:
                MenuProdutos();
                break;
            case 3:
                MenuBanco();
                break;
            case 4:
                Console.WriteLine("\nSaindo do sistema...");
                break;
            default:    
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
        }
        Console.ReadKey();
    } while (opcaoPrincipal != 4);
}
void MenuAlunos()
{
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("\n=========================================");
        Console.WriteLine("\n!!Bem Vindo ao Sistema de Alunos!!");
        Console.WriteLine("\n============= Menu Alunos ==============\n");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1 - Cadastrar Aluno");
        Console.WriteLine("2 - Calcular Idade em mêses");
        Console.WriteLine("3 - Mostrar Informações do Aluno");
        Console.WriteLine("4 - Voltar");
        Console.ResetColor();
        Console.WriteLine("\n=========================================");
        Console.Write("Opção: ");
        bool valido = int.TryParse(Console.ReadLine(), out opcao);
        Console.Clear();
        if (!valido) continue;
        switch (opcao)
        { 
            case 1:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("============ Cadastrar Aluno ============");
                Console.WriteLine("=========================================");
                Console.WriteLine("\nDigite os dados do aluno:");
            
                Aluno.CadastraAluno(listaAlunos);
                break;
            case 2:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("======= Calcular Idades em Mêses ========");
                Console.WriteLine("=========================================");
               
                if (listaAlunos.Count != 0)
                {
                    for (int i = 0; i < listaAlunos.Count; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\n[cod {i + 1}] ");
                        Console.ResetColor();
                        listaAlunos[i].ExibirInfo();
                    }
                }
                else
                {
                    Console.WriteLine("\nAinda não existem alunos cadastrados..\n");
                    Console.ReadKey();
                    break;
                }
                break;
            case 3:
                    Console.WriteLine("\n=========================================");
                    Console.WriteLine("==== Mostrar Informações dos Alunos =====");
                    Console.WriteLine("=========================================");
                if (listaAlunos.Count != 0)
                {
                    for (int i = 0; i < listaAlunos.Count; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"\n[cod {i + 1}] ");
                        Console.ResetColor();
                        listaAlunos[i].ExibirInfo();
                    }
                }
                else
                {
                    Console.WriteLine("\nAinda não existem alunos cadastrados..\n");
                    Console.ReadKey();
                    break;
                }
                break;
            case 4:
                Console.WriteLine("\nVoltando para o menu anterior...");
                break;
            default:
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
        }
        Console.ReadKey();
    } while (opcao != 3);
}
void MenuProdutos()
{
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("\n=========================================");
        Console.WriteLine("\n!!Bem Vindo ao Estoque Show do Milhão!!");
        Console.WriteLine("\n============= Menu Produtos =============\n");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1 - Cadastrar Produto");
        Console.WriteLine("2 - Atualizar Estoque");
        Console.WriteLine("3 - Alterar Nacional/Internacional");
        Console.WriteLine("4 - Voltar");
        Console.ResetColor();
        Console.WriteLine("\n=========================================");
        Console.Write("\nOpção: ");

        bool valido = int.TryParse(Console.ReadLine(), out opcao);
        Console.Clear();

        if (!valido) continue;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("============ Cadastrar Produto ==========");
                Console.WriteLine("=========================================");

                Produto.CadastrarProduto(listaProdutos);

                break;

            case 2:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("========== Atualizar Estoque ============");
                Console.WriteLine("=========================================");

                if (listaProdutos.Count == 0)
                {
                    Console.WriteLine("\nAinda não existem produtos cadastrados..\n");
                    Console.ReadKey();
                    break;
                }


                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n[cod {i + 1}] ");
                    Console.ResetColor();
                    Produto.ExibirInfo(listaProdutos, i);
                }
                Console.WriteLine("\n=========================================");
                Console.Write("\nEscolha pelo número do código de produto: ");
                int cod = int.TryParse(Console.ReadLine(), out cod) ? cod : -1;

                if (cod >= 0 && cod < listaProdutos.Count)
                {
                    Console.Write("Novo estoque: ");
                    int novoEstoque = int.TryParse(Console.ReadLine(), out novoEstoque) ? novoEstoque : listaProdutos[cod].QuantidadeEstoque;
                    listaProdutos[cod].AtualizarEstoque(novoEstoque);
                }
                break;

            case 3:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("=============== Aterar País =============");
                Console.WriteLine("=========================================");

                Produto.AlterarCulturaInternacional();

                Console.WriteLine("\n=========================================");
                break;
            case 4:
                Console.WriteLine("\nVoltando para o menu anterior...");
                break;
            default:
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
        }
        Console.ReadKey();
    } while (opcao != 4);
}
void MenuBanco()
{
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("\n=========================================");
        Console.WriteLine("\n!!Bem Vindo ao Banco ConfiaNoPai!!");
        Console.WriteLine("\n============= Menu Produtos =============\n");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1 - Cadastrar Conta");
        Console.WriteLine("2 - Consultar Saldo em Caixa");
        Console.WriteLine("3 - Selecionar Conta");
        Console.WriteLine("4 - Voltar");
        Console.ResetColor();
        Console.WriteLine("\n=========================================");
        Console.Write("Opção: ");

        bool valido = int.TryParse(Console.ReadLine(), out opcao);
        Console.Clear();

        if (!valido) continue;
        
        switch (opcao)
        {
            case 1:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("=========== Cadastro de Conta ===========");
                Console.WriteLine("=========================================\n");
                ContaBancaria.CadastrarConta(listaContas);
                break;
            case 2:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("============== Caixa Banco ==============");
                Console.WriteLine("=========================================\n");
                decimal total = listaContas.Sum(c => c.Saldo);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Saldo total em caixa: {total:C}");
                Console.ResetColor();
                break;
            case 3:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("=========== Seleção de Conta ============");
                Console.WriteLine("=========================================\n");
                for (int i = 0; i < listaContas.Count; i++)
                {
                    int numeroConta = i + 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"[{numeroConta.ToString("D4")}] ");
                    Console.ResetColor();
                    Console.WriteLine($"{listaContas[i].Titular} - Saldo: {listaContas[i].Saldo:C}");
                }

                Console.Write("\nEscolha o número da conta: ");
                bool parseOk = int.TryParse(Console.ReadLine(), out int escolha);
                int idx = escolha - 1;
                if (parseOk && idx >= 0 && idx < listaContas.Count)
                {
                    total = listaContas.Sum(c => c.Saldo);
                    MenuConta(listaContas[idx], total);
                }
                else
                {
                    Console.WriteLine("\nConta inválida. Pressione qualquer tecla para continuar...");
                }
                break;
            case 4:
                Console.WriteLine("\nVoltando para o menu anterior...");
                break;

            default:
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
        }
        Console.ReadKey();
    } while (opcao != 4);
}
void MenuConta(ContaBancaria conta, decimal totalCaixa)
{
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("\n==========================================");
        Console.WriteLine("\n            Banco ConfiaNoPai");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"   Conta: {conta.Titular} - Saldo: {conta.Saldo:C}    ");
        Console.ResetColor();
        Console.WriteLine("\n================== Menu ==================\n");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1 - Depósito");
        Console.WriteLine("2 - Saque");
        Console.WriteLine("3 - Empréstimo");
        Console.WriteLine("4 - Voltar");
        Console.ResetColor();
        Console.WriteLine("\n==========================================");
        Console.Write("Opção: ");

        bool valido = int.TryParse(Console.ReadLine(), out opcao);
        Console.Clear();
        if (!valido) continue;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("================ Depósitos ==============");
                Console.WriteLine("=========================================");
                Console.WriteLine($"\nSaldo atual: {conta.Saldo.ToString("C", CultureInfo.CurrentCulture)}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nDigite um valor para deposito (Esc para cancelar): ");

                string? input = EscParaCancelar();
                if (input is null)
                {
                    Console.ResetColor();
                    Console.WriteLine("\nOperação cancelada. Voltando para o menu anterior...");
                    break;
                }
                else
                {
                    if (decimal.TryParse(input, out decimal valorDeposito) && valorDeposito > 0)
                    {
                        conta.Depositar(valorDeposito);
                        Console.ResetColor();

                        if (conta.ComprovantePadrao == Comprovante.Simples || conta.ComprovantePadrao == Comprovante.Detalhado)
                        {
                            string comprovanteTipo = conta.ComprovantePadrao == Comprovante.Simples ? "Simples" : "Detalhado";
                            Console.WriteLine($"\nComprovante {comprovanteTipo} selecionado como padrão.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nComprovante: Impresso com sucesso");
                            Console.ResetColor();
                        }
                        else 
                        {
                            Console.WriteLine("\nDeseja selecionar como padrão o comprovante simples ou detatlado?");
                            Console.WriteLine("\n(Digite 1 para Comprovante simples, ou 2 para Detalhado)");
                            char resposta = char.ToLower(Console.ReadKey(true).KeyChar);
                            switch (resposta)
                            {
                                case '1':
                                    conta.ComprovantePadrao = Comprovante.Simples;
                                    Console.WriteLine("\nComprovante simples selecionado como padrão.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nComprovante: Impresso com sucesso");
                                    Console.ResetColor();
                                    break;
                                case '2':
                                    conta.ComprovantePadrao = Comprovante.Detalhado;
                                    Console.WriteLine("\nComprovante detalhado selecionado como padrão.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nComprovante: Impresso com sucesso");
                                    Console.ResetColor();
                                    break;
                                default:
                                    Console.WriteLine("\nOpção inválida. Comprovante não selecionado.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido.");
                    }
                }
                Console.ResetColor();
                Console.WriteLine("\n=========================================");
                break;

            case 2:
                Console.WriteLine("\n=========================================");
                Console.WriteLine("================== Saque ================");
                Console.WriteLine("=========================================");
                Console.WriteLine($"\nSaldo atual: {conta.Saldo.ToString("C", CultureInfo.CurrentCulture)}");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nDigite um valor para saque (Esc para cancelar): ");

                input = EscParaCancelar();
                if (input is null)
                {
                    Console.ResetColor();
                    Console.WriteLine("\nOperação cancelada. Voltando para o menu anterior...");
                    break;
                }
                else
                {
                    if (decimal.TryParse(input, out decimal valorSaque) && valorSaque > 0)
                    {
                        if(valorSaque <= conta.Saldo)
                        {
                            conta.Sacar(valorSaque);
                        }
                        else
                        {
                            Console.WriteLine("\nSaldo insuficiente para realizar o saque.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido.");
                    }
                }
                Console.ResetColor();
                Console.WriteLine("\n=========================================");
                break;

            case 3:
                Emprestimos(conta, totalCaixa);
                break;

            case 4:
                Console.WriteLine("\nVoltando para o menu anterior...");
                break;

            default:
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
        }
        Console.ReadKey();
    } while (opcao != 4);
}
void Emprestimos(ContaBancaria conta, decimal totalCaixa)
{
    Console.WriteLine("\n=========================================");
    Console.WriteLine("=============== Empréstimos =============");
    Console.WriteLine("=========================================");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    ContaBancaria.Emprestimo(conta, totalCaixa);
    Console.ResetColor();
    Console.WriteLine("\n=========================================");

    if (conta.PossuiEmprestimo)
    {
        Console.WriteLine("\nDeseja efeturar o pagamento? (Digite 's' para Sim)");
        char resposta = char.ToLower(Console.ReadKey(true).KeyChar);
        if (resposta != 's')
        {
            ContaBancaria.PagarEmprestimo(conta);
        }
    }
    else
    {
        Console.WriteLine("\nDeseja solicitar um empréstimo? (Digite 's' para Sim)");
        char resposta = char.ToLower(Console.ReadKey(true).KeyChar);
        if (resposta != 's')
        {
            //ContaBancaria2.PagarEmprestimo(conta); // Criar um metodo para solicitar empréstimo
        }
    }
}
static string? EscParaCancelar()
{
    StringBuilder sb = new();
    while (true)
    {
        var keyInfo = Console.ReadKey(intercept: true);
        if (keyInfo.Key == ConsoleKey.Escape)
            return null;
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            break;
        }
        Console.Write(keyInfo.KeyChar);
        sb.Append(keyInfo.KeyChar);
    }
    return sb.ToString();
}

using Aula14.ClassOO;
using TarefasAulaOO.Aula14;
using System.Globalization;
using System.Text;

//// Static -----------------------------------------------------------------------------------------------

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


//---------------------------------------------------------------------------------------------------------
//Maos Na Massa -------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------


List <Produto2> listaProdutos = new();
List<ContaBancaria2> listaContas = new();

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
                // Alunos
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

                Produto2.CadastrarProduto(listaProdutos);

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
                    Produto2.ExibirInfo(listaProdutos, i);
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

                Produto2.AlterarCulturaInternacional();

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
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo Inicial: ");
                decimal saldo = decimal.TryParse(Console.ReadLine(), out saldo) ? saldo : 0;
                Console.Write("Renda Mensal: ");
                decimal renda = decimal.TryParse(Console.ReadLine(), out renda) ? renda : 0;
                listaContas.Add(new ContaBancaria2(titular, saldo, renda));
                break;
            case 2:
                decimal total = listaContas.Sum(c => c.Saldo);
                Console.WriteLine($"Saldo total em caixa: {total:C}");
                break;
            case 3:
                for (int i = 0; i < listaContas.Count; i++)
                    Console.WriteLine($"[{i}] {listaContas[i].Titular} - Saldo: {listaContas[i].Saldo:C}");
                Console.Write("Escolha o número da conta: ");
                int idx = int.TryParse(Console.ReadLine(), out idx) ? idx : -1;
                if (idx >= 0 && idx < listaContas.Count)
                {
                    total = listaContas.Sum(c => c.Saldo);
                    MenuConta(listaContas[idx], total);
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
void MenuConta(ContaBancaria2 conta, decimal totalCaixa)
{
    int opcao;
    do
    {
        Console.Clear();
        Console.WriteLine("\n==========================================");
        Console.WriteLine("\n            Banco ConfiaNoPai");
        Console.WriteLine($"=== Conta: {conta.Titular} - Saldo: {conta.Saldo:C} ===");
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
void Emprestimos(ContaBancaria2 conta, decimal totalCaixa)
{
    Console.WriteLine("\n=========================================");
    Console.WriteLine("=============== Empréstimos =============");
    Console.WriteLine("=========================================");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    ContaBancaria2.Emprestimo(conta, totalCaixa);
    Console.ResetColor();
    Console.WriteLine("\n=========================================");

    if (conta.PossuiEmprestimo)
    {
        Console.WriteLine("\nDeseja efeturar o pagamento? (Digite 's' para Sim)");
        char resposta = char.ToLower(Console.ReadKey(true).KeyChar);
        if (resposta != 's')
        {
            ContaBancaria2.PagarEmprestimo(conta);
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
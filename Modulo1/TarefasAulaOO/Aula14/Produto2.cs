namespace TarefasAulaOO.Aula14
{
    public class Produto2
    {

        private int _quantidadeEstoque;

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque
        {
            get
            {
                return _quantidadeEstoque;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Quantidade em estoque não pode ser negativa. Mantendo o valor anterior.");
                }
                else
                {
                    _quantidadeEstoque = value;
                }
            }
        }

        public static void ExecutarTarefa1()
        {
            Console.WriteLine("Bem-vindo ao Estoquista ShowDoMilhão!");
            Console.ReadKey();
            //decimal saldo = 0;
            //int opcao = 0;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("\nDo While---------------------------------------------------\n");

            //    Console.WriteLine("Estoquista ShowDoMilhão, seja bem-vindo!\n");
            //    Console.WriteLine("1 - Consultar saldo");
            //    Console.WriteLine("2 - Realizar depósito");
            //    Console.WriteLine("3 - Realizar saque");
            //    Console.WriteLine("4 - Sair");

            //    Console.WriteLine("\n-----------------------------------------------------------\n");

            //    Console.Write("Escolha uma opção: ");

            //    var escolha = Console.ReadLine();
            //    bool escolhaValida = int.TryParse(escolha, out opcao);

            //    Console.Clear();

            //    switch (opcao)
            //    {
            //        case 1:
            //            Console.WriteLine($"\n\nSeu saldo atual é: R$ {saldo:F2}");
            //            break;

            //        case 2:
            //            Console.Write("\n\nDigite o valor para depósito: R$ ");
            //            var depositoEntrada = Console.ReadLine();
            //            bool depositoRealizado = decimal.TryParse(depositoEntrada, out decimal deposito);

            //            if (deposito > 0)
            //            {
            //                saldo += deposito;
            //                Console.WriteLine($"\nDepósito de R$ {deposito:F2} realizado com sucesso.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("\nValor inválido para depósito.");
            //            }
            //            break;

            //        case 3:
            //            Console.Write("\n\nDigite o valor para saque: R$ ");
            //            var saqueEntrada = Console.ReadLine();
            //            bool saqueRealizado = decimal.TryParse(saqueEntrada, out decimal saque);

            //            if (saque > 0 && saque <= saldo)
            //            {
            //                saldo -= saque;
            //                Console.WriteLine($"\nSaque de R$ {saque:F2} realizado com sucesso.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("\nSaque inválido ou saldo insuficiente.");
            //            }
            //            break;

            //        case 4:
            //            Console.WriteLine("\n\nObrigado por utilizar o Banco +Devs2Blu. Volte sempre!");
            //            break;

            //        default:
            //            Console.WriteLine("\n\nOpção inválida. Tente novamente.");
            //            break;
            //    }

            //    if (opcao != 4)
            //    {
            //        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            //        Console.ReadKey();
            //    }

            //} while (opcao != 4);
        }

        public void AtualizarEstoque(int quantidade)
        {
            if (quantidade < 0)
            {
                Console.WriteLine($"A quantidade se mantêm: {QuantidadeEstoque}");
            }
            else
            {
                QuantidadeEstoque = quantidade;
                Console.WriteLine($"Estoque atualizado. Nova quantidade: {QuantidadeEstoque}");
            }
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome do Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Quantidade em Estoque: {QuantidadeEstoque}");
        }
    }
}

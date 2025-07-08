namespace TarefasAulaOO.Aula14
{
    public class ContaBancaria2
    {
        public static decimal _Saldo = 0;
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public static void ExecutarTarefa2()
        {
            Console.WriteLine("Bem-vindo ao Banco ConfiaNoPai!");
            Console.ReadKey();
            //decimal saldo = 0;
            //int opcao = 0;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("\nDo While---------------------------------------------------\n");

            //    Console.WriteLine("Banco ConfiaNoPai, seja bem-vindo!\n");
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

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta de {Titular}: {Saldo:C}");
        }
    }
}
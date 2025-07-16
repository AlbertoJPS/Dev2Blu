using System.Globalization;
using Aula15.Enums;

namespace TarefasAulaOO
{
    public class ContaBancaria
    {
        public const int FATOR_PROVISIONAMENTO = 5;
        public const decimal RENDA_MINIMA_PERCENTUAL = 0.5m;

        private static decimal _TotalCaixa = 100000;
        private static int _ContagemContas = 0;
        private bool _PossuiEmprestimo = false;
        public static decimal TotalCaixa
        {
            get
            {
                 return _TotalCaixa;
            }
        }
        public static int ContagemContas { get => _ContagemContas; }

        
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }
        public decimal RendaMensal { get; set; }
        //public decimal ValorEmprestimo { get; private set; }
        public bool PossuiEmprestimo { get => _PossuiEmprestimo;  }
        //public decimal TotalCaixa { get => _TotalCaixa; }

        public Comprovante ComprovantePadrao { get; set; }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            _ContagemContas++;
        }

        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
            _ContagemContas++;
        }

        public ContaBancaria(string titular, decimal saldoInicial, decimal rendaMensal)
        {
            Titular = titular;
            Saldo = saldoInicial;
            RendaMensal = rendaMensal;
            _ContagemContas++;
        }

        public static void CadastrarConta(List<ContaBancaria> listaContas)
        {
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("\nSaldo Inicial: ");
            decimal saldo = decimal.TryParse(Console.ReadLine(), out saldo) ? saldo : 0;
            Console.Write("\nRenda Mensal (deixe 0 se não houver): ");
            decimal renda = decimal.TryParse(Console.ReadLine(), out renda) ? renda : 0;

            ContaBancaria novaConta;
            if (renda > 0)
            {
                novaConta = new ContaBancaria(titular, saldo, renda);
            }
            else
            {
                novaConta = new ContaBancaria(titular, saldo);
            }

            listaContas.Add(novaConta);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nA conta de {titular} foi cadastrada com sucesso!");
            Console.ResetColor();
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            _TotalCaixa += valor;
            Console.WriteLine($"\nDepósito de {valor.ToString("C", CultureInfo.CurrentCulture)} realizado com sucesso. Saldo atual: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
            _TotalCaixa -= valor;
            Console.WriteLine($"\nSaque de {valor.ToString("C", CultureInfo.CurrentCulture)} realizado com sucesso. Saldo atual: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\nSaldo atual da conta de {Titular}: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public static void Emprestimo(ContaBancaria conta, decimal totalCaixa)
        {
            if (conta.PossuiEmprestimo)
            {
                Console.WriteLine("\nVocê possui um empréstimo ativo.\n\n");
                //Console.WriteLine($"Valor do empréstimo atual: {conta.ValorEmprestimo.ToString("C", CultureInfo.CurrentCulture)}");
                return;
            }
            else
            {
                Console.Write("\nDigite o valor desejado para o empréstimo: ");

                bool valor = decimal.TryParse(Console.ReadLine(), out decimal valorSolicitado);


                if (totalCaixa > valorSolicitado * FATOR_PROVISIONAMENTO)
                {
                    if (valorSolicitado < conta.RendaMensal * RENDA_MINIMA_PERCENTUAL)
                    {
                       // conta.ValorEmprestimo = valorSolicitado;
                        conta.Saldo += valorSolicitado;
                        _TotalCaixa -= valorSolicitado;
                        Console.WriteLine($"\nEmpréstimo de {valorSolicitado.ToString("C", CultureInfo.CurrentCulture)} concedido com sucesso.");
                        Console.WriteLine($"\nNovo saldo: {conta.Saldo.ToString("C", CultureInfo.CurrentCulture)}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nEmpréstimo recusado: valor solicitado excede 50% da sua renda mensal.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("\nEmpréstimo recusado: o banco não possui saldo suficiente em caixa para esta operação.");
                    return;
                }
            }
        }

        public static void PagarEmprestimo(ContaBancaria conta)
        {
           // if (conta.Saldo >= conta.ValorEmprestimo)
           // {
               // conta.Saldo -= conta.ValorEmprestimo;
               // _TotalCaixa += conta.ValorEmprestimo;
               // conta.ValorEmprestimo = 0;
                Console.WriteLine("\nEmpréstimo quitado com sucesso!");
           
           // }
           // else
           // {
           //     Console.WriteLine("\nSaldo insuficiente para quitação da dívida. Faça um depósito do valor faltante para prosseguir.");
           // }
        }
    }
}

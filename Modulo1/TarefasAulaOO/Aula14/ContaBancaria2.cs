using System.Globalization;
using Aula15.Enums;

namespace TarefasAulaOO.Aula14
{
    public class ContaBancaria2
    {
        public const int FATOR_PROVISIONAMENTO = 5;
        public const decimal RENDA_MINIMA_PERCENTUAL = 0.5m;

        public static decimal _TotalCaixa = 100000;
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }
        public decimal RendaMensal { get; set; }
        public decimal ValorEmprestimo { get; private set; }
        public bool PossuiEmprestimo => ValorEmprestimo > 0;
        public decimal TotalCaixa { get => _TotalCaixa; }

        public Comprovante ComprovantePadrao { get; set; }

        public ContaBancaria2() { }

        public ContaBancaria2(string titular, decimal saldoInicial, decimal rendaMensal)
        {
            Titular = titular;
            Saldo = saldoInicial;
            RendaMensal = rendaMensal;
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

        public static void Emprestimo(ContaBancaria2 conta, decimal totalCaixa)
        {
            if (conta.PossuiEmprestimo)
            {
                Console.WriteLine("\nVocê possui um empréstimo ativo.\n\n");
                Console.WriteLine($"Valor do empréstimo atual: {conta.ValorEmprestimo.ToString("C", CultureInfo.CurrentCulture)}");
                return;
            }
            else
            {
                bool valor = decimal.TryParse(Console.ReadLine(), out decimal valorSolicitado);


                if (totalCaixa > (valorSolicitado * FATOR_PROVISIONAMENTO))
                {
                    if (valorSolicitado < (conta.RendaMensal * RENDA_MINIMA_PERCENTUAL))
                    {
                        conta.ValorEmprestimo = valorSolicitado;
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

        public static void PagarEmprestimo(ContaBancaria2 conta)
        {
            if (conta.Saldo >= conta.ValorEmprestimo)
            {
                conta.Saldo -= conta.ValorEmprestimo;
                _TotalCaixa += conta.ValorEmprestimo;
                conta.ValorEmprestimo = 0;
                Console.WriteLine("\nEmpréstimo quitado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nSaldo insuficiente para quitação da dívida. Faça um depósito do valor faltante para prosseguir.");
            }
        }
    }
}

using System.Globalization;

namespace TarefasAulaOO.Aula14
{
    public class ContaBancaria2
    {
        public const int FATOR_PROVISIONAMENTO = 5;
        public const decimal RENDA_MINIMA_PERCENTUAL = 0.5m;

        public static bool _PossuiEmprestimo = false;
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }
        public decimal RendaMensal { get; set; }
        public decimal ValorEmprestimo { get; private set; }
        public bool PossuiEmprestimo => ValorEmprestimo > 0;

        public ContaBancaria2() { }

        public ContaBancaria2(string titular, decimal saldoInicial, decimal rendaMensal)
        {
            Titular = titular;
            Saldo = saldoInicial;
            RendaMensal = rendaMensal;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor.ToString("C", CultureInfo.CurrentCulture)} realizado com sucesso. Saldo atual: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
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
                Console.WriteLine($"Saque de {valor.ToString("C", CultureInfo.CurrentCulture)} realizado com sucesso. Saldo atual: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
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
            Console.WriteLine($"Saldo atual da conta de {Titular}: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
        }

        public static void Emprestimo(ContaBancaria2 conta, decimal totalCaixa)
        {
            if (conta.PossuiEmprestimo)
            {
                Console.WriteLine("\nVocê possui um empréstimo ativo.\n\n");
                Console.WriteLine("====Situação do seu Emprestimo====")
                return;
            }
            else
            {
                bool valor = decimal.TryParse(Console.ReadLine(), out decimal valorSolicitado);
                

                if (totalCaixa > (valorSolicitado * FATOR_PROVISIONAMENTO))
                {
                    if (valorSolicitado < (conta.RendaMensal * RENDA_MINIMA_PERCENTUAL))
                    {
                        _PossuiEmprestimo = true;
                        conta.ValorEmprestimo = valorSolicitado;    
                        conta.Saldo += valorSolicitado;
                        Console.WriteLine($"\nEmpréstimo de {valorSolicitado.ToString("C", CultureInfo.CurrentCulture)} concedido com sucesso.");
                        Console.WriteLine($"\nNovo saldo: {conta.Saldo.ToString("C", CultureInfo.CurrentCulture)}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Empréstimo recusado: valor solicitado excede 50% da sua renda mensal.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Empréstimo recusado: o banco não possui saldo suficiente em caixa para esta operação.");
                    return;
                }
            }

        }
        //public static bool SolicitarEmprestimo(ContaBancaria2 conta, decimal valorSolicitado, decimal saldoTotalBanco)
        //{
        //    if (conta.PossuiEmprestimo)
        //    {
        //        Console.WriteLine("Você já possui um empréstimo ativo.");
        //        return false;
        //    }
        //    if (valorSolicitado > (conta.RendaMensal * 0.5m))
        //    {
        //        Console.WriteLine("Empréstimo recusado: valor solicitado excede 50% da sua renda mensal.");
        //        return false;
        //    }
        //    if (saldoTotalBanco < (valorSolicitado * 5))
        //    {
        //        Console.WriteLine("Empréstimo recusado: o banco não possui saldo suficiente em caixa para esta operação.");
        //        return false;
        //    }
        //    conta.ValorEmprestimo = valorSolicitado;
        //    conta.Saldo += valorSolicitado;
        //    Console.WriteLine($"Empréstimo de {valorSolicitado.ToString("C", CultureInfo.CurrentCulture)} concedido com sucesso. Novo saldo: {conta.Saldo.ToString("C", CultureInfo.CurrentCulture)}");
        //    return true;
        //}

        //public bool SolicitarEmprestimo(decimal valorSolicitado, decimal saldoTotalBanco)
        //{
        //    if (PossuiEmprestimo)
        //    {
        //        Console.WriteLine("Você já possui um empréstimo ativo.");
        //        return false;
        //    }

        //    if (valorSolicitado > (RendaMensal * 0.5m))
        //    {
        //        Console.WriteLine("Empréstimo recusado: valor solicitado excede 50% da sua renda mensal.");
        //        return false;
        //    }

        //    if (saldoTotalBanco < (valorSolicitado * 5))
        //    {
        //        Console.WriteLine("Empréstimo recusado: o banco não possui saldo suficiente em caixa para esta operação.");
        //        return false;
        //    }

        //    ValorEmprestimo = valorSolicitado;
        //    Saldo += valorSolicitado;
        //    Console.WriteLine($"Empréstimo de {valorSolicitado.ToString("C", CultureInfo.CurrentCulture)} concedido com sucesso. Novo saldo: {Saldo.ToString("C", CultureInfo.CurrentCulture)}");
        //    return true;
        //}

        public void ConsultarEmprestimo()
        {
            if (PossuiEmprestimo)
            {
                Console.WriteLine($"Valor do empréstimo atual: {ValorEmprestimo.ToString("C", CultureInfo.CurrentCulture)}");
            }
            else
            {
                Console.WriteLine("Nenhum empréstimo ativo.");
            }
        }
    }
}

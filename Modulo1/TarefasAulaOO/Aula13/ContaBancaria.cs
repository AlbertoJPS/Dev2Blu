namespace TarefasAulaOO.Aula13
{
    internal class ContaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

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
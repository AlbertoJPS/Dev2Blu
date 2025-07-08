namespace TarefasAulaOO.Aula13
{
    internal class Produto
    {

        private int _quantidadeEstoque;

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { 
            get {
                return _quantidadeEstoque;
            } 
            set { 
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

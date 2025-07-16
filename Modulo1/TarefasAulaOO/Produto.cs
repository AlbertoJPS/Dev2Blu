using System.Globalization;

namespace TarefasAulaOO
{
    public class Produto
    {
        private int _quantidadeEstoque;
        private static bool _internacional = false; // padrão nacional

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque
        {
            get => _quantidadeEstoque;
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

        public Produto() { }

        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public static void CadastrarProduto(List<Produto> lista)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNome inválido! Produto não foi cadastrado.");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Preço: ");
                string precoInput = Console.ReadLine() ?? "";
                if (!double.TryParse(precoInput, out double preco))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPreço inválido! Produto não foi cadastrado.");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Quantidade: ");
                string qtdInput = Console.ReadLine() ?? "";
                if (!int.TryParse(qtdInput, out int qtd))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nQuantidade inválida! Produto não foi cadastrado.");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                lista.Add(new Produto(nome, preco, qtd));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nProduto cadastrado com sucesso!");
                Console.ResetColor();
                Console.WriteLine("\nDeseja cadastrar outro produto? (digite 's' para continuar): ");
                char resposta = char.ToLower(Console.ReadKey(true).KeyChar);
                if (resposta != 's')
                {
                    continuar = false;
                }
            }
        }
        
        public static void AlterarCulturaInternacional()
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentCulture.Name == "pt-BR"
                ? new CultureInfo("en-US")
                : new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nCultura alterada para: {Thread.CurrentThread.CurrentCulture.Name}");
            Console.ResetColor();
        }

        public void AtualizarEstoque(int quantidade)
        {
            if (quantidade < 0)
            {
                Console.WriteLine($"A quantidade se mantém: {QuantidadeEstoque}");
            }
            else
            {
                QuantidadeEstoque = quantidade;
                Console.WriteLine($"Estoque atualizado. Nova quantidade: {QuantidadeEstoque}");
            }
        }

        public static void ExibirInfo(List<Produto> lista, int index)
        {
            Console.Write($" Produto: {lista[index].Nome} -");
            Console.Write($" Preço: {lista[index].Preco.ToString("C")} -");
            Console.WriteLine($" Estoque: {lista[index].QuantidadeEstoque}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16
{
    public class Produto
    {
        private string Nome { get; set; }
        private decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public static void ExibirInfo(List<Produto> lista, int index)
        {
            Console.Write($" Produto: {lista[index].Nome} -");
            Console.Write($" Preço: {lista[index].Preco.ToString("C")}");
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
                if (!decimal.TryParse(precoInput, out decimal preco))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPreço inválido! Produto não foi cadastrado.");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                lista.Add(new Produto(nome, preco));
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
        public static string ExibirNome(Produto produtoSelecionado)
        {
            return produtoSelecionado.Nome;
        }
        public static decimal ExibirPreco(Produto produtoSelecionado)
        {
            return produtoSelecionado.Preco;
        }

        public static void AlterarNome(Produto produtoSelecionado, string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome inválido! Alteração não realizada.");
                Console.ResetColor();
                return;
            }

            produtoSelecionado.Nome = novoNome;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto teve seu nome alterado para: {novoNome}");
            Console.ResetColor();
        }
        
        public static void AlterarPreco(Produto produtoSelecionado)
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal novoPreco) && novoPreco <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Preço inválido! Alteração não realizada.");
                Console.ResetColor();
                return;
            }
            produtoSelecionado.Preco = novoPreco;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto teve seu preço alterado para: {novoPreco.ToString("C")}");
            Console.ResetColor();
        }
    }
}

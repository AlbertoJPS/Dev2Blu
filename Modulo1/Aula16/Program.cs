using Aula16;

namespace Aula16
{
    public class Program
    {
        private static List<Produto> _ListaProdutos = new List<Produto>();

        public static void Main(string[] args)
        {
            Program.MenuProdutos();
        }
        public static void MenuProdutos()
        {
            try
            {
                int opcao;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n=========================================");
                    Console.WriteLine("\n             !!Bem Vindoo!!");
                    Console.WriteLine("\n=========================================\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("1 - Cadastrar Produto");
                    Console.WriteLine("2 - Listar Produtos");
                    Console.WriteLine("3 - Alterar Nome Produto");
                    Console.WriteLine("4 - Alterar Preço Produto");
                    Console.WriteLine("5 - Sair");
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

                            Produto.CadastrarProduto(_ListaProdutos);

                            break;
                        case 2:
                            Console.WriteLine("\n=========================================");
                            Console.WriteLine("========== Listar Produtos ============");
                            Console.WriteLine("=========================================");

                            ListarProdutos();
                            break;
                        case 3:
                            Console.WriteLine("\n=========================================");
                            Console.WriteLine("========= Alterar Nome Produto ==========");
                            Console.WriteLine("=========================================");

                            ListarProdutos();
                            Console.WriteLine("\n\n=========================================");
                            Console.Write("\nDigite o código do produto que deseja alterar: ");
                            bool codigoValido = int.TryParse(Console.ReadLine(), out int codigo);
                            Console.Clear();

                            if (!codigoValido || codigo < 1 || codigo > _ListaProdutos.Count)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nCódigo inválido! Produto não foi encontrado.");
                                Console.ResetColor();
                                Console.WriteLine("\nPressione uma tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }

                            var produto = _ListaProdutos[codigo - 1];
                            Console.WriteLine($"\nNome atual do produto: {Produto.ExibirNome(produto)}");
                            Console.Write("\nDigite o novo nome do produto: ");
                            string novoNome = Console.ReadLine();
                            Produto.AlterarNome(produto, novoNome);
                            Console.WriteLine("\nNome do produto atualizado com sucesso!");

                            break;
                        case 4:
                            Console.WriteLine("\n=========================================");
                            Console.WriteLine("========= Alterar Preço Produto =========");
                            Console.WriteLine("=========================================");

                            ListarProdutos();
                            Console.WriteLine("\n\n=========================================");
                            Console.Write("\nDigite o código do produto que deseja alterar: ");
                            codigoValido = int.TryParse(Console.ReadLine(), out codigo);
                            Console.Clear();

                            if (!codigoValido || codigo < 1 || codigo > _ListaProdutos.Count)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nCódigo inválido! Produto não foi encontrado.");
                                Console.ResetColor();
                                Console.WriteLine("\nPressione uma tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }

                            produto = _ListaProdutos[codigo - 1];
                            Console.WriteLine($"\nO Preço atual do produto {Produto.ExibirNome(produto)}: {Produto.ExibirPreco(produto)}");
                            Console.Write("\nDigite o novo nome do produto: ");
                            Produto.AlterarPreco(produto);
                            Console.WriteLine("\nNome do produto atualizado com sucesso!");
                            break;
                        case 5:
                            Console.WriteLine("\nSaindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida. Tente novamente.");
                            break;
                    }
                    Console.ReadKey();
                } while (opcao != 5);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nErro: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
            }
        }
        public static void ListarProdutos()
        {
            if (_ListaProdutos.Count == 0)
            {
                Console.WriteLine("\nAinda não existem produtos cadastrados..\n");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < _ListaProdutos.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n[cod {i + 1}] ");
                Console.ResetColor();
                Produto.ExibirInfo(_ListaProdutos, i);
            }
        }
        
        
    }
}


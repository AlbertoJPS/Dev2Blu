using Sistema_Central.Entities;
using Sistema_Central.Utilitários;

namespace Sistema_Central.Utilitários
{
    public class Service
    {
        public static bool ObjetivoPlanetaCompatibilidade(ObjetivoMissao objetivo, SituacaoPlaneta estadoPlaneta)
        {
            return objetivo switch
            {
                ObjetivoMissao.Reconhecimento => estadoPlaneta == SituacaoPlaneta.Inexplorado || estadoPlaneta == SituacaoPlaneta.Hostil,
                ObjetivoMissao.ColetaRecursos => estadoPlaneta == SituacaoPlaneta.FonteDeRecursos,
                ObjetivoMissao.Colonizacao => estadoPlaneta == SituacaoPlaneta.Habitavel,
                ObjetivoMissao.Combate => estadoPlaneta == SituacaoPlaneta.Hostil,
                ObjetivoMissao.Pesquisa => estadoPlaneta != SituacaoPlaneta.Habitavel || estadoPlaneta == SituacaoPlaneta.FonteDeRecursos,
                _ => false
            };
        }

        public static int LerOpcaoValida(int maxOpcao)
        {
            int escolha;
            Console.Write("\nEscolha uma opção: ");
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > maxOpcao)
            {
                Console.Write("Opção inválida. Tente novamente: ");
            }
            return escolha;
        }

        public static TipoEnum SelecionarOpcaoEnum<TipoEnum>() where TipoEnum : Enum
        {
            var opcoes = Enum.GetValues(typeof(TipoEnum)).Cast<TipoEnum>().ToList();

            Console.WriteLine($"\nSelecione uma opção ({typeof(TipoEnum).Name}):\n");

            for (int i = 0; i < opcoes.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[{i + 1}] {opcoes[i]}");
                Console.ResetColor();
            }

            int escolha = LerOpcaoValida(opcoes.Count);
            var selecionado = opcoes[escolha - 1];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nOpção selecionada: {selecionado}");
            Console.ResetColor();

            return selecionado;
        }

        public static List<TipoEnum> SelecionarMultiplasOpcoesEnum<TipoEnum>() where TipoEnum : Enum
        {
            var opcoes = Enum.GetValues(typeof(TipoEnum)).Cast<TipoEnum>().ToList();

            Console.WriteLine($"\nSelecione uma ou mais opções ({typeof(TipoEnum).Name}), separadas por vírgula:\n");

            for (int i = 0; i < opcoes.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[{i + 1}] {opcoes[i]}");
                Console.ResetColor();
            }

            Console.Write("\nDigite os números das opções (ex: 1,3,4): ");
            string entrada = Console.ReadLine();
            var selecionados = new List<TipoEnum>();

            if (!string.IsNullOrWhiteSpace(entrada))
            {
                var partes = entrada.Split(',');

                foreach (var parte in partes)
                {
                    if (int.TryParse(parte.Trim(), out int index) && index >= 1 && index <= opcoes.Count)
                    {
                        var item = opcoes[index - 1];
                        if (!selecionados.Contains(item))
                            selecionados.Add(item);
                    }
                }
            }

            if (selecionados.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhuma opção válida selecionada.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nOpções selecionadas:");
                foreach (var item in selecionados)
                    Console.WriteLine($" - {item}");
                Console.ResetColor();
            }

            return selecionados;
        }
        public static string LerTextoObrigatorio(string mensagem)
        {
            string? entrada;
            do
            {
                Console.Write(mensagem);
                entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este campo é obrigatório. Tente novamente.");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(entrada));

            return entrada;
        }
    }
}

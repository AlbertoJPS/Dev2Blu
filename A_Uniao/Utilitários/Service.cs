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
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha >= maxOpcao + 1)
            {
                Console.Write("\nOpção inválida. Tente novamente: ");
            }
            return escolha;
        }
        public static TipoEnum SelecionarOpcaoEnum<TipoEnum>() where TipoEnum : Enum
        {
            Array opcoesEnum = Enum.GetValues(typeof(TipoEnum));

            Console.WriteLine($"\nSelecione uma opção para {typeof(TipoEnum).Name}:");

            for (int i = 0; i < opcoesEnum.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"\n[{i + 1}] {opcoesEnum.GetValue(i)}");
                Console.ResetColor();
            }

            Console.Write("\nDigite o número correspondente à opção desejada: ");

            int escolha;
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha >= opcoesEnum.Length + 1)
            {
                Console.Write("Opção inválida. Tente novamente: ");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nOpcão selecionada: {opcoesEnum.GetValue(escolha - 1)}");
            Console.ResetColor();

            return (TipoEnum)opcoesEnum.GetValue(escolha - 1);
        }
    }
}

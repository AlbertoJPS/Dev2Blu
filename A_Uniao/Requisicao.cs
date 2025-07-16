using Sistema_Central.Entities;
using Sistema_Central.Utilitários;

namespace Sistema_Central
{
    public class Requisicao
    {
        public static List<Missao> RequisitarMissao(List<Planeta> listaDePlanetas, List<Nave> listaDeNaves, List<Missao> listaDeMissoes, List<Astronauta> ListaDeAstronautas)
        {
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("\nRequisitando missão ao QG...\n");
            Console.WriteLine("==========================================================");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine("Preencha os dados da missão abaixo:");
            Console.WriteLine("==========================================================\n");

            Console.Write("Digite o nome da missão: ");
            string nomeMissao = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nomeMissao))
            {
                Console.Write("\nNome inválido. \n\nDigite um nome válido para a missão: ");
                nomeMissao = Console.ReadLine();
            }

            ObjetivoMissao objetivo = Service.SelecionarOpcaoEnum<ObjetivoMissao>();

            // Filtro de planetas compatíveis
            List<Planeta> planetasCompativeis = new List<Planeta>();
            foreach (var planeta in listaDePlanetas)
            {
                if (Service.ObjetivoPlanetaCompatibilidade(objetivo, planeta.SituacaoAtual))
                {
                    planetasCompativeis.Add(planeta);
                }
            }

            if (planetasCompativeis.Count == 0)
            {
                Console.WriteLine("Nenhum planeta disponível compatível com o objetivo escolhido.");
                return listaDeMissoes;
            }

            Console.WriteLine("\nPlanetas compatíveis:");
            for (int i = 0; i < planetasCompativeis.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var p = planetasCompativeis[i];
                Console.WriteLine($"\n[{i + 1}] {p.Nome} - {p.SituacaoAtual}, Distância: {p.DistanciaEmUA} UA");
                Console.ResetColor();
            }
            int escolhaPlaneta = Service.LerOpcaoValida(planetasCompativeis.Count);
            Planeta planetaDestino = planetasCompativeis[escolhaPlaneta - 1];
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nPlaneta selecionado: {planetaDestino.Nome} - {planetaDestino.SituacaoAtual}");
            Console.ResetColor();

            // Filtro de naves compatíveis
            List<Nave> navesCompativeis = new List<Nave>();
            foreach (var nave in listaDeNaves)
            {
                bool naveDisponivel = nave.EstadoAtualNave == SituacaoNave.Disponivel;
                bool suporteObjetivo = nave.TiposDeMissaoSuportados.Contains(objetivo);
                bool alcanceSuficiente = nave.DistanciaMaximaViagem >= planetaDestino.DistanciaEmUA;

                if (naveDisponivel && suporteObjetivo && alcanceSuficiente)
                {
                    navesCompativeis.Add(nave);
                }
            }

            if (navesCompativeis.Count == 0)
            {
                Console.WriteLine("Nenhuma nave disponível compatível com o objetivo e planeta selecionados.");
                return listaDeMissoes;
            }

            Console.WriteLine("\nNaves compatíveis:");
            for (int i = 0; i < navesCompativeis.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                var n = navesCompativeis[i];
                Console.WriteLine($"\n[{i + 1}] {n.Nome} - {n.Modelo}, Porte: {n.Porte}, Alcance: {n.DistanciaMaximaViagem} UA, Capacidade: {n.CapacidadeMaximaTripulantes}");
                Console.ResetColor();
            }
            int escolhaNave = Service.LerOpcaoValida(navesCompativeis.Count);
            Nave naveSelecionada = navesCompativeis[escolhaNave - 1];
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nNave selecionada: {naveSelecionada.Nome} - {naveSelecionada.Modelo}");
            Console.ResetColor();

            // Solicita duração da missão
            Console.Write("\nInforme a duração da missão (em dias): ");
            int duracaoDias;
            while (!int.TryParse(Console.ReadLine(), out duracaoDias) || duracaoDias <= 0)
            {
                Console.Write("Valor inválido. Digite um número inteiro positivo: ");
            }

            // Cria a missão
            var novaMissao = new Missao(nomeMissao, objetivo, duracaoDias, planetaDestino, naveSelecionada)
            {
                EstadoMissao = SituacaoMissao.Pendente
            };

            listaDeMissoes.Add(novaMissao);

            Console.WriteLine("\n\n==========================================================");
            Console.WriteLine("Missão requisitada com sucesso!");
            Console.WriteLine("==========================================================\n");

            return listaDeMissoes;
        }
    }
}

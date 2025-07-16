using Sistema_Central.Entities;
using Sistema_Central.Utilitários;
using System;
using System.Collections.Generic;

namespace Sistema_Central.Utilitários
{
    internal class Service
    {
        public static List<Missao> RequisitarMissao(
            List<Missao> listaDeMissoes,
            List<Nave> listaDeNaves,
            List<Planeta> listaDePlanetas)
        {
            Console.WriteLine("\nRequisitando missão ao QG...\n");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Preencha os dados da missão abaixo:");
            Console.WriteLine("Observação: As datas devem ser informadas no formato dd/mm/yyyy.");
            Console.WriteLine("==========================================================\n");

            Console.Write("Digite o nome da missão: ");
            string nomeMissao = Console.ReadLine();

            ObjetivoMissao objetivo = Seletores.SelecionarOpcaoEnum<ObjetivoMissao>();

            // Busca planetas compatíveis (foreach)
            List<Planeta> planetasCompativeis = new List<Planeta>();
            foreach (var planeta in listaDePlanetas)
            {
                if (ObjetivoPlanetaCompatibilidade(objetivo, planeta.SituacaoAtual))
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
                Console.WriteLine($"[{i}] {planetasCompativeis[i].Nome} (Estado: {planetasCompativeis[i].SituacaoAtual})");
            }

            int escolhaPlaneta = LerOpcaoValida(planetasCompativeis.Count);
            Planeta planetaDestino = planetasCompativeis[escolhaPlaneta];

            // Busca naves compatíveis (foreach)
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
                Console.WriteLine($"[{i}] {navesCompativeis[i].Nome} (Modelo: {navesCompativeis[i].Modelo})");
            }

            int escolhaNave = LerOpcaoValida(navesCompativeis.Count);
            Nave naveSelecionada = navesCompativeis[escolhaNave];

            DateTime dataLancamento = LerDataValida("Digite a data de lançamento (dd/mm/yyyy): ");

            DateTime dataRetornoPrevisto;
            while (true)
            {
                dataRetornoPrevisto = LerDataValida("Digite a data de retorno previsto (dd/mm/yyyy): ");
                var duracao = (dataRetornoPrevisto - dataLancamento).TotalDays;

                if (duracao <= 0)
                {
                    Console.WriteLine("A data de retorno deve ser posterior à data de lançamento.");
                }
                else if (duracao > 300)
                {
                    Console.WriteLine("A duração da missão não pode exceder 300 dias. Digite a data novamente.");
                }
                else
                {
                    break;
                }
            }

            var novaMissao = new Missao(nomeMissao, objetivo, dataLancamento, dataRetornoPrevisto, planetaDestino, naveSelecionada)
            {
                EstadoMissao = SituacaoMissao.Pendente
            };

            listaDeMissoes.Add(novaMissao);

            Console.WriteLine("==========================================================");
            Console.WriteLine("Missão requisitada com sucesso!");
            Console.WriteLine("==========================================================\n");

            return listaDeMissoes;
        }

        private static bool ObjetivoPlanetaCompatibilidade(ObjetivoMissao objetivo, SituacaoPlaneta estadoPlaneta)
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

        private static int LerOpcaoValida(int maxOpcao)
        {
            int escolha;
            Console.Write("Escolha uma opção: ");
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha >= maxOpcao)
            {
                Console.Write("Opção inválida. Tente novamente: ");
            }
            return escolha;
        }

        private static DateTime LerDataValida(string mensagem)
        {
            Console.Write(mensagem);
            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.Write("Data inválida. Digite novamente: ");
            }
            return data;
        }
    }
}

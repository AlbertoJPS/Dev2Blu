using Sistema_Central.Entities;
using Sistema_Central.Utilitários;

namespace Sistema_Central
{
    public class MostrarDados
    {
        public static void MostrarAstronauta(Astronauta astronauta)
        {
            Console.WriteLine($"Nome: {astronauta.Nome}");
            Console.WriteLine($"Idade: {astronauta.Idade}");
            Console.WriteLine($"Nacionalidade: {astronauta.Nacionalidade}");
            Console.WriteLine($"Nascimento: {astronauta.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Situação: {astronauta.EstadoAstronauta}");
            Console.WriteLine($"Tripulando: {(astronauta.TripulandoNave != null ? astronauta.TripulandoNave.Nome : "Nenhuma")}");
            Console.WriteLine("-------------------------------------------");
        }
        public static void MostrarNave(Nave nave)
        {
            Console.WriteLine($"Nome: {nave.Nome} | Modelo: {nave.Modelo}");
            Console.WriteLine($"Porte: {nave.Porte}");
            Console.WriteLine($"Fabricante: {nave.Fabricante}");
            Console.WriteLine($"Situação Atual: {nave.EstadoAtualNave}");
            Console.WriteLine($"Capacidade de Tripulantes: {nave.CapacidadeMaximaTripulantes}");

            Console.WriteLine($"Distância Máxima (UA): {nave.DistanciaMaximaViagem:F1}");

            Console.WriteLine("Objetivos Suportados: " + string.Join(" / ", nave.TiposDeMissaoSuportados));

            if (nave.TripulacaoEmbarcada != null && nave.TripulacaoEmbarcada.Count > 0)
            {
                List<string> nomesTripulantes = new List<string>();

                foreach (Astronauta tripulante in nave.TripulacaoEmbarcada)
                {
                    nomesTripulantes.Add(tripulante.Nome);
                }
                Console.WriteLine($"Tripulação Atual: {string.Join(", ", nomesTripulantes)}");
            }
            else
            {
                Console.WriteLine("Tripulação Atual: [Nenhum tripulante designado]");
            }

            Console.WriteLine("-------------------------------------------");
        }
        public static void MostrarPlaneta(Planeta planeta)
        {
            Console.WriteLine($"Nome: {planeta.Nome}");
            Console.WriteLine($"Descrição: {planeta.Descricao}");
            Console.WriteLine($"Distância (UA): {planeta.DistanciaEmUA}");
            Console.WriteLine($"Situação: {planeta.SituacaoAtual}");
            Console.WriteLine("-------------------------------------------");
        }
        public static void MostrarMissoes(Missao missao)
        {
            Console.WriteLine($"Nome da Missão: {missao.Nome}");
            Console.WriteLine($"Objetivo: {missao.Objetivo}");
            Console.WriteLine($"Duração da Missão: {missao.DuracaoMissao} dias");

            if (missao.DataLancamento == DateTime.MinValue)
            {
                Console.WriteLine("Data de Lançamento: [Não definido]");
            }
            else
            {
                Console.WriteLine($"Data de Lançamento: {missao.DataLancamento.ToShortDateString()}");
            }

            if (missao.DataRetornoPrevisto == DateTime.MinValue)
            {
                Console.WriteLine("Data de Retorno Previsto: [Não definido]");
            }
            else
            {
                Console.WriteLine($"Data de Retorno Previsto: {missao.DataRetornoPrevisto.ToShortDateString()}");
            }

            Console.WriteLine($"Situação: {missao.EstadoMissao}");
            Console.WriteLine($"Planeta Alvo: {missao.Destino.Nome}");
            Console.WriteLine($"Nave Designada: {missao.Nave.Nome}");

            if (missao.TripulacaoMissao != null && missao.TripulacaoMissao.Count > 0)
            {
                List<string> nomes = new List<string>();
                foreach (var tripulante in missao.TripulacaoMissao)
                {
                    nomes.Add(tripulante.Nome);
                }
                Console.WriteLine($"Tripulação: {string.Join(", ", nomes)}");
            }
            else
            {
                Console.WriteLine("Tripulação: [Ainda não designada]");
            }

            Console.WriteLine("-------------------------------------------");
        }

        public static void ExibirVisaoGeral(List<Planeta> planetas, List<Nave> naves, List<Missao> missoes, List<Astronauta> astronautas)
        {
            MostrarDados.ExibirResumoAstronautas(astronautas);
            MostrarDados.ExibirResumoNaves(naves);
            MostrarDados.ExibirResumoPlanetas(planetas);
            MostrarDados.ExibirResumoMissoes(missoes);
        }
        public static void ExibirResumoAstronautas(List<Astronauta> astronautas)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ASTRONAUTAS:\n");

            int total = astronautas.Count;
            int emMissao = 0, feridos = 0, mortos = 0;
            Dictionary<PaisAstronauta, int> disponiveisPorPais = new();

            foreach (PaisAstronauta pais in Enum.GetValues(typeof(PaisAstronauta)))
            {
                disponiveisPorPais[pais] = 0;
            }

            foreach (var astro in astronautas)
            {
                switch (astro.EstadoAstronauta)
                {
                    case SituacaoAstronauta.Disponivel:
                        disponiveisPorPais[astro.Nacionalidade]++;
                        break;
                    case SituacaoAstronauta.EmMissao: 
                        emMissao++; 
                        break;
                    case SituacaoAstronauta.Ferido: 
                        feridos++; 
                        break;
                    case SituacaoAstronauta.Morto: 
                        mortos++; 
                        break;
                }
            }

            Console.WriteLine($"\n- Total Cadastrados: {total}");
            Console.WriteLine($"\n- Em Missão: {emMissao}");
            Console.WriteLine($"\n- Feridos: {feridos}");
            Console.WriteLine($"\n- Mortos: {mortos}");
            Console.WriteLine($"\n- Disponíveis por País:\n");
            foreach (var item in disponiveisPorPais)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"  -- {item.Key}: {item.Value}");
                }
                    
            }
            Console.ResetColor();
        }
        public static void ExibirResumoNaves(List<Nave> naves)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNAVES:");

            int disponiveis = 0, perdidas = 0, avariadas = 0;
            var porPaisEObjetivo = new Dictionary<PaisFabricante, Dictionary<ObjetivoMissao, int>>();

            foreach (PaisFabricante pais in Enum.GetValues(typeof(PaisFabricante)))
            {
                porPaisEObjetivo[pais] = new();
                foreach (ObjetivoMissao obj in Enum.GetValues(typeof(ObjetivoMissao)))
                {
                    porPaisEObjetivo[pais][obj] = 0;
                }
            }

            foreach (var nave in naves)
            {
                if (nave.EstadoAtualNave == SituacaoNave.Disponivel) disponiveis++;
                else if (nave.EstadoAtualNave == SituacaoNave.Avariada) avariadas++;
                else if (nave.EstadoAtualNave == SituacaoNave.Perdida) perdidas++;

                foreach (var obj in nave.TiposDeMissaoSuportados)
                {
                    porPaisEObjetivo[nave.Fabricante][obj]++;
                } 
            }

            Console.WriteLine($"\n- No Hangar (Disponíveis): {disponiveis}");
            Console.WriteLine($"\n- Avariadas: {avariadas}");
            Console.WriteLine($"\n- Perdidas: {perdidas}");
            Console.WriteLine($"\n- Tipos de Missão por País:\n");
            foreach (var pais in porPaisEObjetivo.Keys)
            {
                Console.WriteLine($"  -- {pais}:");
                foreach (var obj in porPaisEObjetivo[pais])
                {
                    if (obj.Value > 0)
                    {
                        Console.WriteLine($"   - {obj.Key}: {obj.Value}");
                    }
                }
            }
            Console.ResetColor();
        }
        public static void ExibirResumoPlanetas(List<Planeta> planetas)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nPLANETAS:");

            int habitaveis = 0, inexplorados = 0, hostis = 0, fontes = 0;

            foreach (var planeta in planetas)
            {
                switch (planeta.SituacaoAtual)
                {
                    case SituacaoPlaneta.Habitavel: 
                        habitaveis++; 
                        break;
                    case SituacaoPlaneta.Inexplorado: 
                        inexplorados++; 
                        break;
                    case SituacaoPlaneta.Hostil: 
                        hostis++; 
                        break;
                    case SituacaoPlaneta.FonteDeRecursos: 
                        fontes++; 
                        break;
                }
            }

            Console.WriteLine($"\n- Total Conhecidos: {planetas.Count}");
            Console.WriteLine($"\n- Habitáveis: {habitaveis}");
            Console.WriteLine($"\n- Inexplorados: {inexplorados}");
            Console.WriteLine($"\n- Hostis: {hostis}");
            Console.WriteLine($"\n- Fontes de Recursos: {fontes}");

            Console.ResetColor();
        }
        public static void ExibirResumoMissoes(List<Missao> missoes)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMISSÕES:");

            int total = missoes.Count;
            Dictionary<ObjetivoMissao, int> porObjetivo = new();
            Dictionary<SituacaoMissao, int> porSituacao = new();
            HashSet<string> astronautas = new();

            foreach (ObjetivoMissao obj in Enum.GetValues(typeof(ObjetivoMissao)))
            {
                porObjetivo[obj] = 0;
            }

            foreach (SituacaoMissao sit in Enum.GetValues(typeof(SituacaoMissao)))
            {
                porSituacao[sit] = 0;
            }

            foreach (var missao in missoes)
            {
                porObjetivo[missao.Objetivo]++;
                porSituacao[missao.EstadoMissao]++;
                foreach (var a in missao.TripulacaoMissao)
                {
                    astronautas.Add(a.Nome);
                }
            }

            Console.WriteLine($"\n- Total Realizadas: {total}");

            Console.WriteLine("\n- Por Objetivo:\n");
            foreach (var item in porObjetivo)
            {
                Console.WriteLine($"  -- {item.Key}: {item.Value}");
            }
                
            Console.WriteLine("\n- Por Situação:\n");
            foreach (var item in porSituacao)
            {
                Console.WriteLine($"  -- {item.Key}: {item.Value}");
            }
                
            Console.WriteLine($"\n- Total de Astronautas Participantes: {astronautas.Count}");
            Console.ResetColor();
        }

    }
}


using Sistema_Central.Entities;
using Sistema_Central.Utilitários;

namespace Sistema_Central.BancoSimulado
{
    public static class PopularBanco
    {
        public static void PopularPlanetas(List<Planeta> lista)
        {
            lista.Add(new Planeta("Gaia Prime", "Planeta semelhante à Terra", 0.8, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Orion IV", "Ambiente hostil e agressivo", 3.2, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Xenon 7", "Quase nenhuma informação disponível", 5.6, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Nova Terra", "Potencial para colonização", 1.4, SituacaoPlaneta.Colonizavel));
            lista.Add(new Planeta("Kepler-22b", "Temperatura e clima favoráveis", 2.2, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Helion", "Rico em minérios energéticos", 1.8, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Abyss", "Radiação e clima extremos", 6.1, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Erebus", "Totalmente desconhecido", 4.9, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Valhalla", "Terreno estável e fértil", 3.0, SituacaoPlaneta.Colonizavel));
            lista.Add(new Planeta("Zeta Reticuli", "Fonte ativa de minerais", 2.5, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Thalos", "Sem missões anteriores registradas", 6.8, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Prometheus", "Tempestades constantes e perigosas", 5.2, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Artemis", "Boa atmosfera e água potável", 1.9, SituacaoPlaneta.Colonizavel));
            lista.Add(new Planeta("Vulcan", "Atividade vulcânica mínima", 1.1, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Nemesis", "Presença de vida hostil", 7.3, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Ceres II", "Reservas subterrâneas valiosas", 2.6, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Draco", "Nenhuma exploração registrada", 4.3, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Echo", "Ambiente promissor para bases", 1.7, SituacaoPlaneta.Colonizavel));
            lista.Add(new Planeta("Lunaris", "Gravidade e clima ideais", 0.6, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Chronos", "Zona de guerra abandonada", 6.7, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Vortex", "Atividade geológica intensa", 2.3, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Borealis", "Cartografia incompleta", 5.9, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Titanus", "Grande planície colonizável", 2.0, SituacaoPlaneta.Colonizavel));
            lista.Add(new Planeta("Astra 9", "Ambiente similar ao terrestre", 1.2, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Zorgon", "Nível extremo de perigos naturais", 4.7, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Hydra", "Desconhecido, sem dados confiáveis", 6.5, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Morpheus", "Riqueza mineral abundante", 2.9, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Elysium", "Terras férteis e temperatura amena", 1.5, SituacaoPlaneta.Colonizavel));
            lista.Add(new Planeta("Nebula X", "Zona de conflito alienígena", 7.0, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Eden Prime", "Ambiente paradisíaco", 0.9, SituacaoPlaneta.Habitavel));
        }
        public static void PopularNaves(List<Nave> lista)
        {
            lista.Add(new Nave("Aurora", "X-100", PorteNave.Média, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento, ObjetivoMissao.Pesquisa }));
            lista.Add(new Nave("Tempest", "Viper MkII", PorteNave.Pequena, PaisFabricante.Russia, SituacaoNave.EmMissao, new List<ObjetivoMissao> { ObjetivoMissao.Combate }));
            lista.Add(new Nave("Andromeda", "Galaxy C1", PorteNave.Grande, PaisFabricante.China, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao, ObjetivoMissao.ColetaRecursos }));
            lista.Add(new Nave("Nova", "Explorer 7", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento, ObjetivoMissao.Pesquisa }));
            lista.Add(new Nave("Atlas", "Heavy Lander", PorteNave.Média, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }));
            lista.Add(new Nave("Sentinel", "Guardian", PorteNave.Pequena, PaisFabricante.EstadosUnidos, SituacaoNave.EmMissao, new List<ObjetivoMissao> { ObjetivoMissao.Combate }));
            lista.Add(new Nave("Equinox", "EQ-22", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.ColetaRecursos }));
            lista.Add(new Nave("Nebula", "N1-Speed", PorteNave.Pequena, PaisFabricante.China, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento }));
            lista.Add(new Nave("Valkyrie", "Combat-X", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.EmMissao, new List<ObjetivoMissao> { ObjetivoMissao.Combate, ObjetivoMissao.Pesquisa }));
            lista.Add(new Nave("Odyssey", "Colonizer-Z", PorteNave.Grande, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }));
            lista.Add(new Nave("Helios", "Miner-MAX", PorteNave.Média, PaisFabricante.Russia, SituacaoNave.Perdida, new List<ObjetivoMissao> { ObjetivoMissao.ColetaRecursos }));
            lista.Add(new Nave("Specter", "Scout S-1", PorteNave.Pequena, PaisFabricante.China, SituacaoNave.Perdida, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento }));
            lista.Add(new Nave("Leviathan", "Colossus V", PorteNave.Grande, PaisFabricante.UniãoEuropeia, SituacaoNave.Avariada, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao, ObjetivoMissao.ColetaRecursos }));
            lista.Add(new Nave("Comet", "Light-Flyer", PorteNave.Pequena, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa }));
            lista.Add(new Nave("Phantom", "C-Stealth", PorteNave.Pequena, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Combate }));
            lista.Add(new Nave("Pioneer", "PX-One", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa, ObjetivoMissao.Reconhecimento }));
            lista.Add(new Nave("Horizon", "HZ-9", PorteNave.Grande, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }));
            lista.Add(new Nave("Crusader", "Battle-Knight", PorteNave.Média, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Combate }));
            lista.Add(new Nave("Starlight", "Star-Miner", PorteNave.Média, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.ColetaRecursos }));
            lista.Add(new Nave("Discovery", "Science-Delta", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa }));
        }
    }
}

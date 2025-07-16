
using Sistema_Central.Entities;
using Sistema_Central.Utilitários;
using System.Collections.Generic;

namespace Sistema_Central.BancoSimulado
{
    public static class PopularBanco
    {
        public static bool PopularTudo(List<Planeta> planetas, List<Nave> naves, List<Missao> missoes, List<Astronauta> astronautas, bool jaPopulado)
        {
            if (jaPopulado)
            { 
                return false; 
            }
            else
            {
                PopularPlanetas(planetas);
                PopularNaves(naves);
                PopularMissoes(missoes, naves, planetas);
                PopularAstronautas(astronautas, naves);

                return true;
            }
        }

        public static void PopularPlanetas(List<Planeta> lista)
        {
            // Habitáveis 
            lista.Add(new Planeta("Lunaris", "Gravidade e clima ideais", 12.3, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Eden Prime", "Ambiente paradisíaco", 3.7, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Caladros", "Ambiente promissor para bases", 9.1, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Astra 9", "Ambiente similar ao terrestre", 1.6, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Xernes", "Planeta semelhante à Terra", 6.4, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Valhalla", "Terreno estável e fértil", 13.8, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Titanus", "Grande planície colonizável", 2.1, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Artemis", "Boa atmosfera e água potável", 10.5, SituacaoPlaneta.Habitavel));
            lista.Add(new Planeta("Elysium", "Terras férteis e temperatura amena", 7.2, SituacaoPlaneta.Habitavel));

            // Fontes de Recursos 
            lista.Add(new Planeta("Helion", "Rico em minérios energéticos", 4.8, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Zeta Reticuli", "Fonte ativa de minerais", 13.0, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Vortex", "Atividade geológica intensa", 2.9, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Morpheus", "Riqueza mineral abundante", 8.6, SituacaoPlaneta.FonteDeRecursos));
            lista.Add(new Planeta("Ceres II", "Reservas subterrâneas valiosas", 6.7, SituacaoPlaneta.FonteDeRecursos));

            // Inexplorados 
            lista.Add(new Planeta("Draco", "Nenhuma exploração registrada", 3.1, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Erebus", "Totalmente desconhecido", 11.4, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Borealis", "Cartografia incompleta", 1.4, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Thalos", "Sem missões anteriores registradas", 6.2, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Hydra", "Desconhecido, sem dados confiáveis", 9.7, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Xenon 7", "Quase nenhuma informação disponível", 5.0, SituacaoPlaneta.Inexplorado));
            lista.Add(new Planeta("Zorgon", "Nível extremo de perigos naturais", 12.9, SituacaoPlaneta.Inexplorado));

            // Hostis 
            lista.Add(new Planeta("Prometheus", "Tempestades constantes e perigosas", 8.0, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Abyss", "Radiação e clima extremos", 10.1, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Chronos", "Zona de guerra abandonada", 4.2, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Nemesis", "Presença de vida hostil", 7.5, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Nebula X", "Zona de conflito alienígena", 13.9, SituacaoPlaneta.Hostil));
            lista.Add(new Planeta("Theraxis", "Ambiente hostil e agressivo", 1.9, SituacaoPlaneta.Hostil));
        }


        public static void PopularNaves(List<Nave> lista)
        {
            // 🇺🇸 Estados Unidos — versatilidade e quantidade
            lista.Add(new Nave("Liberty", "X-7", PorteNave.Média, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao, ObjetivoMissao.Pesquisa }, 8, 7));
            lista.Add(new Nave("Endeavour", "Z-Class", PorteNave.Grande, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento, ObjetivoMissao.ColetaRecursos }, 14, 12));
            lista.Add(new Nave("Orion", "M5", PorteNave.Pequena, PaisFabricante.EstadosUnidos, SituacaoNave.EmMissao, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento }, 5, 3));
            lista.Add(new Nave("Pioneer", "S3", PorteNave.Média, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa }, 9, 6));
            lista.Add(new Nave("Freedom", "XL", PorteNave.Grande, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Combate }, 13, 14));
            lista.Add(new Nave("Voyager", "Scout", PorteNave.Média, PaisFabricante.EstadosUnidos, SituacaoNave.Avariada, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa }, 7.2, 6));
            lista.Add(new Nave("Eagle", "Light", PorteNave.Pequena, PaisFabricante.EstadosUnidos, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento }, 4.8, 2));

            // 🇷🇺 Rússia — robustez, combate e grande porte
            lista.Add(new Nave("Tsar", "T-90", PorteNave.Grande, PaisFabricante.Russia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Combate }, 15, 15));
            lista.Add(new Nave("Zvezda", "Z-9", PorteNave.Média, PaisFabricante.Russia, SituacaoNave.Perdida, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }, 6.9, 8));
            lista.Add(new Nave("Soyuz-X", "Heavy", PorteNave.Grande, PaisFabricante.Russia, SituacaoNave.EmMissao, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa }, 12.5, 13));
            lista.Add(new Nave("Volkov", "VK-2", PorteNave.Grande, PaisFabricante.Russia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.ColetaRecursos }, 11.2, 10));

            // 🇨🇳 China — equilíbrio e tecnologia avançada
            lista.Add(new Nave("Long March", "L-5", PorteNave.Média, PaisFabricante.China, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }, 7.5, 7));
            lista.Add(new Nave("Fênix Celestial", "F-1", PorteNave.Média, PaisFabricante.China, SituacaoNave.EmMissao, new List<ObjetivoMissao> { ObjetivoMissao.Combate }, 8.1, 6));
            lista.Add(new Nave("Shenzhou 9", "Shen-Class", PorteNave.Pequena, PaisFabricante.China, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento }, 3.9, 2));

            // 🇪🇺 União Europeia — exploração e pesquisa
            lista.Add(new Nave("Gaia", "E-1", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Pesquisa }, 6.5, 8));
            lista.Add(new Nave("Athena", "A-Class", PorteNave.Grande, PaisFabricante.UniãoEuropeia, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }, 13.5, 14));
            lista.Add(new Nave("Europa I", "EXP-9", PorteNave.Média, PaisFabricante.UniãoEuropeia, SituacaoNave.Perdida, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento }, 6.8, 7));

            // 🇮🇳 Índia — ciência, tradição e defesa
            lista.Add(new Nave("Vikram", "V-2025", PorteNave.Pequena, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Reconhecimento, ObjetivoMissao.Pesquisa }, 4.4, 3));
            lista.Add(new Nave("Agni", "A-13", PorteNave.Pequena, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Combate }, 5.1, 4));
            lista.Add(new Nave("Saraswati", "S-Class", PorteNave.Média, PaisFabricante.India, SituacaoNave.Disponivel, new List<ObjetivoMissao> { ObjetivoMissao.Colonizacao }, 6.7, 6));
        }

        public static void PopularMissoes(List<Missao> listaMissoes, List<Nave> listaNaves, List<Planeta> listaPlanetas)
        {
            // Missão 1 – EM ANDAMENTO
            var nave1 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Orion")]; // 5.0 UA
            var planeta1 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Chronos")]; // 4.2 UA
            nave1.EstadoAtualNave = SituacaoNave.EmMissao;
            listaMissoes.Add(new Missao(
                "Observação de Anomalias",
                ObjetivoMissao.Reconhecimento,
                DateTime.Now.AddDays(-15),
                DateTime.Now.AddDays(60),
                planeta1,
                nave1
            )
            {
                EstadoMissao = SituacaoMissao.EmAndamento
            });

            // Missão 2 – EM ANDAMENTO
            var nave2 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Soyuz-X")]; // 12.5 UA
            var planeta2 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Lunaris")]; // 12.3 UA
            nave2.EstadoAtualNave = SituacaoNave.EmMissao;
            listaMissoes.Add(new Missao(
                "Pesquisa Subterrânea",
                ObjetivoMissao.Pesquisa,
                DateTime.Now.AddDays(-30),
                DateTime.Now.AddDays(90),
                planeta2,
                nave2
            )
            {
                EstadoMissao = SituacaoMissao.EmAndamento
            });

            // Missão 3 – EM ANDAMENTO
            var nave3 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Fênix Celestial")]; // 8.1 UA
            var planeta3 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Prometheus")]; // 8.0 UA
            nave3.EstadoAtualNave = SituacaoNave.EmMissao;
            listaMissoes.Add(new Missao(
                "Operação Escudo Divino",
                ObjetivoMissao.Combate,
                DateTime.Now.AddDays(-10),
                DateTime.Now.AddDays(50),
                planeta3,
                nave3
            )
            {
                EstadoMissao = SituacaoMissao.EmAndamento
            });

            // Missão 4 – CANCELADA
            var nave4 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Voyager")]; // 7.2 UA
            var planeta4 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Elysium")]; // 7.2 UA
            nave4.EstadoAtualNave = SituacaoNave.Avariada;
            listaMissoes.Add(new Missao(
                "Exploração Profunda",
                ObjetivoMissao.Pesquisa,
                DateTime.Now.AddDays(-40),
                DateTime.Now.AddDays(20),
                planeta4,
                nave4
            )
            {
                EstadoMissao = SituacaoMissao.Cancelada
            });

            // Missão 5 – FALHOU
            var nave5 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Zvezda")]; // 6.9 UA
            var planeta5 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Xernes")]; // 6.4 UA
            nave5.EstadoAtualNave = SituacaoNave.Perdida;
            listaMissoes.Add(new Missao(
                "Colônia Fracassada Zvezda",
                ObjetivoMissao.Colonizacao,
                DateTime.Now.AddDays(-120),
                DateTime.Now.AddDays(-10),
                planeta5,
                nave5
            )
            {
                EstadoMissao = SituacaoMissao.Falhou
            });

            // Missão 6 – FALHOU
            var nave6 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Europa I")]; // 6.8 UA
            var planeta6 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Thalos")]; // 6.2 UA 
            nave6.EstadoAtualNave = SituacaoNave.Perdida;
            listaMissoes.Add(new Missao(
                "Sinal Silenciado",
                ObjetivoMissao.Reconhecimento,
                DateTime.Now.AddDays(-80),
                DateTime.Now.AddDays(-5),
                planeta6,
                nave6
            )
            {
                EstadoMissao = SituacaoMissao.Falhou
            });

            // Missão 7 – CONCLUÍDA
            var nave7 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Gaia")]; // 6.5 UA
            var planeta7 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Helion")]; // 4.8 UA
            nave7.EstadoAtualNave = SituacaoNave.Disponivel;
            listaMissoes.Add(new Missao(
                "Estudo Energético Helion",
                ObjetivoMissao.Pesquisa,
                DateTime.Now.AddDays(-90),
                DateTime.Now.AddDays(-5),
                planeta7,
                nave7
            )
            {
                EstadoMissao = SituacaoMissao.Concluida
            });

            // Missão 8 – CONCLUÍDA
            var nave8 = listaNaves[listaNaves.FindIndex(n => n.Nome == "Tsar")]; // 15.0 UA
            var planeta8 = listaPlanetas[listaPlanetas.FindIndex(p => p.Nome == "Nebula X")]; // 13.9 UA
            nave8.EstadoAtualNave = SituacaoNave.Disponivel;
            listaMissoes.Add(new Missao(
                "Operação Martelo Escarlate",
                ObjetivoMissao.Combate,
                DateTime.Now.AddDays(-60),
                DateTime.Now.AddDays(-1),
                planeta8,
                nave8
            )
            {
                EstadoMissao = SituacaoMissao.Concluida
            });
        }

        public static void PopularAstronautas(List<Astronauta> lista, List<Nave> naves)
        {
            // Missão Falha - Zvezda (8 mortos)
            lista.Add(new Astronauta("Dmitri Ivanov", PaisAstronauta.Russia, new DateTime(1982, 4, 10), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Natalya Petrova", PaisAstronauta.Russia, new DateTime(1985, 6, 14), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Sergei Volkov", PaisAstronauta.Russia, new DateTime(1978, 3, 21), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Olga Smirnova", PaisAstronauta.Russia, new DateTime(1990, 11, 5), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Viktor Sokolov", PaisAstronauta.Russia, new DateTime(1981, 7, 28), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Yuri Denisov", PaisAstronauta.Russia, new DateTime(1984, 2, 2), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Irina Pavlova", PaisAstronauta.Russia, new DateTime(1986, 12, 18), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));
            lista.Add(new Astronauta("Anatoly Morozov", PaisAstronauta.Russia, new DateTime(1979, 9, 1), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Zvezda")));

            // Missão Falha - Europa I (7 mortos)
            lista.Add(new Astronauta("Jean Dupont", PaisAstronauta.França, new DateTime(1983, 8, 22), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));
            lista.Add(new Astronauta("Hans Müller", PaisAstronauta.Alemanha, new DateTime(1980, 5, 10), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));
            lista.Add(new Astronauta("Francesca Bianchi", PaisAstronauta.Italia, new DateTime(1985, 1, 3), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));
            lista.Add(new Astronauta("Sophie Laurent", PaisAstronauta.França, new DateTime(1987, 10, 15), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));
            lista.Add(new Astronauta("Luca Romano", PaisAstronauta.Italia, new DateTime(1981, 12, 30), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));
            lista.Add(new Astronauta("Erik Schneider", PaisAstronauta.Alemanha, new DateTime(1979, 4, 6), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));
            lista.Add(new Astronauta("Claire Dubois", PaisAstronauta.França, new DateTime(1988, 3, 27), SituacaoAstronauta.Morto, naves.First(n => n.Nome == "Europa I")));

            // Missão Cancelada - Voyager (3 feridos)
            lista.Add(new Astronauta("John Walker", PaisAstronauta.EstadosUnidos, new DateTime(1982, 6, 9), SituacaoAstronauta.Ferido, naves.First(n => n.Nome == "Voyager")));
            lista.Add(new Astronauta("Rachel Moore", PaisAstronauta.Canada, new DateTime(1984, 5, 11), SituacaoAstronauta.Ferido, naves.First(n => n.Nome == "Voyager")));
            lista.Add(new Astronauta("Carlos Mendez", PaisAstronauta.EstadosUnidos, new DateTime(1986, 8, 17), SituacaoAstronauta.Ferido, naves.First(n => n.Nome == "Voyager")));

            // Missão Cancelada - Voyager (3 retornaram disponíveis)
            lista.Add(new Astronauta("Emily Johnson", PaisAstronauta.EstadosUnidos, new DateTime(1985, 7, 3)));
            lista.Add(new Astronauta("Akira Sato", PaisAstronauta.Japao, new DateTime(1983, 10, 20)));
            lista.Add(new Astronauta("Marco Russo", PaisAstronauta.Italia, new DateTime(1981, 2, 14)));

            // Missão Em Andamento - Orion (3)
            lista.Add(new Astronauta("Tom Harris", PaisAstronauta.EstadosUnidos, new DateTime(1987, 11, 5), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Orion")));
            lista.Add(new Astronauta("Satoshi Nakamura", PaisAstronauta.Japao, new DateTime(1982, 4, 12), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Orion")));
            lista.Add(new Astronauta("Lucas Braun", PaisAstronauta.Alemanha, new DateTime(1984, 9, 28), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Orion")));

            // Missão Em Andamento - Soyuz-X (13)
            lista.Add(new Astronauta("Mikhail Leonov", PaisAstronauta.Russia, new DateTime(1983, 12, 19), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Ivan Federov", PaisAstronauta.Russia, new DateTime(1977, 5, 4), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Elena Kuznetsova", PaisAstronauta.Russia, new DateTime(1985, 6, 1), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Maxim Orlov", PaisAstronauta.Russia, new DateTime(1981, 8, 16), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Tatiana Ivanova", PaisAstronauta.Russia, new DateTime(1986, 3, 30), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Roman Mirov", PaisAstronauta.Russia, new DateTime(1982, 1, 21), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Aleksandr Vetrov", PaisAstronauta.Russia, new DateTime(1984, 7, 8), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Igor Lebedev", PaisAstronauta.Russia, new DateTime(1980, 10, 17), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Nina Belova", PaisAstronauta.Russia, new DateTime(1987, 9, 5), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Daria Koroleva", PaisAstronauta.Russia, new DateTime(1983, 2, 12), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Andrei Zhukov", PaisAstronauta.Russia, new DateTime(1986, 4, 27), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Maria Volkova", PaisAstronauta.Russia, new DateTime(1981, 11, 2), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));
            lista.Add(new Astronauta("Valery Antonov", PaisAstronauta.Russia, new DateTime(1978, 6, 14), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Soyuz-X")));

            // Missão Em Andamento - Fênix Celestial (6)
            lista.Add(new Astronauta("Li Wei", PaisAstronauta.China, new DateTime(1985, 5, 7), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Fênix Celestial")));
            lista.Add(new Astronauta("Zhang Min", PaisAstronauta.China, new DateTime(1983, 11, 13), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Fênix Celestial")));
            lista.Add(new Astronauta("Wang Shu", PaisAstronauta.China, new DateTime(1986, 9, 25), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Fênix Celestial")));
            lista.Add(new Astronauta("Chen Xia", PaisAstronauta.China, new DateTime(1982, 7, 18), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Fênix Celestial")));
            lista.Add(new Astronauta("Liu Feng", PaisAstronauta.China, new DateTime(1984, 12, 4), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Fênix Celestial")));
            lista.Add(new Astronauta("Sun Tao", PaisAstronauta.China, new DateTime(1987, 1, 29), SituacaoAstronauta.EmMissao, naves.First(n => n.Nome == "Fênix Celestial")));

            // Disponíveis
            lista.Add(new Astronauta("George Miller", PaisAstronauta.EstadosUnidos, new DateTime(1980, 9, 1)));
            lista.Add(new Astronauta("Isabella Chen", PaisAstronauta.Canada, new DateTime(1986, 6, 23)));
            lista.Add(new Astronauta("Takeshi Nakamura", PaisAstronauta.Japao, new DateTime(1984, 11, 8)));
            lista.Add(new Astronauta("Anna Schmidt", PaisAstronauta.Alemanha, new DateTime(1985, 3, 16)));
            lista.Add(new Astronauta("Camila Ferrari", PaisAstronauta.Italia, new DateTime(1983, 8, 4)));
            lista.Add(new Astronauta("David O'Connell", PaisAstronauta.Canada, new DateTime(1981, 12, 1)));
            lista.Add(new Astronauta("Jin Park", PaisAstronauta.Japao, new DateTime(1982, 2, 15)));
            lista.Add(new Astronauta("Sabrina Costa", PaisAstronauta.Italia, new DateTime(1986, 10, 11)));
            lista.Add(new Astronauta("Emily Johnson", PaisAstronauta.EstadosUnidos, new DateTime(1990, 3, 14)));
            lista.Add(new Astronauta("Lucas Reed", PaisAstronauta.EstadosUnidos, new DateTime(1989, 6, 22)));
            lista.Add(new Astronauta("Chen Wei", PaisAstronauta.China, new DateTime(1985, 11, 9)));
            lista.Add(new Astronauta("Aiko Tanaka", PaisAstronauta.Japao, new DateTime(1992, 4, 1)));
            lista.Add(new Astronauta("Leonardo Moretti", PaisAstronauta.Italia, new DateTime(1988, 1, 17)));
            lista.Add(new Astronauta("Isabelle Lefevre", PaisAstronauta.França, new DateTime(1991, 9, 3)));
            lista.Add(new Astronauta("Tobias Krause", PaisAstronauta.Alemanha, new DateTime(1987, 12, 25)));
            lista.Add(new Astronauta("Naoko Yamada", PaisAstronauta.Japao, new DateTime(1984, 5, 7)));
            lista.Add(new Astronauta("Matthew Carter", PaisAstronauta.EstadosUnidos, new DateTime(1986, 10, 10)));
            lista.Add(new Astronauta("Sophia Brooks", PaisAstronauta.Canada, new DateTime(1993, 2, 20)));
            lista.Add(new Astronauta("Anjali Singh", PaisAstronauta.EstadosUnidos, new DateTime(1990, 7, 15)));
            lista.Add(new Astronauta("Viktor Ivanenko", PaisAstronauta.Russia, new DateTime(1982, 11, 4)));
            lista.Add(new Astronauta("Nina Kuznetsova", PaisAstronauta.Russia, new DateTime(1995, 6, 29)));
            lista.Add(new Astronauta("Zhang Min", PaisAstronauta.China, new DateTime(1987, 8, 30)));
            lista.Add(new Astronauta("Julia Schneider", PaisAstronauta.Alemanha, new DateTime(1991, 3, 12)));
            lista.Add(new Astronauta("Giulia Conti", PaisAstronauta.Italia, new DateTime(1989, 4, 19)));
            lista.Add(new Astronauta("Alexandre Dubois", PaisAstronauta.França, new DateTime(1986, 12, 8)));
            lista.Add(new Astronauta("Emma White", PaisAstronauta.Canada, new DateTime(1992, 10, 5)));
            lista.Add(new Astronauta("Mikhail Sidorov", PaisAstronauta.Russia, new DateTime(1980, 1, 27)));
            lista.Add(new Astronauta("Kenji Nakamura", PaisAstronauta.Japao, new DateTime(1983, 9, 16)));
        }

        public static void ExibirDadosCompletos(List<Planeta> planetas, List<Nave> naves, List<Missao> missoes, List<Astronauta> astronautas)
        {
            Console.WriteLine("\n================ PLANETAS ================\n");

            foreach (var planeta in planetas)
            {
                Console.WriteLine($"Nome: {planeta.Nome}");
                Console.WriteLine($"Descrição: {planeta.Descricao}");
                Console.WriteLine($"Distância (UA): {planeta.DistanciaEmUA}");
                Console.WriteLine($"Situação: {planeta.SituacaoAtual}");
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("\n================ NAVES ===================\n");

            foreach (var nave in naves)
            {
                Console.WriteLine($"Nome: {nave.Nome} | Modelo: {nave.Modelo}");
                Console.WriteLine($"Porte: {nave.Porte}");
                Console.WriteLine($"Fabricante: {nave.Fabricante}");
                Console.WriteLine($"Situação Atual: {nave.EstadoAtualNave}");
                Console.WriteLine($"Capacidade de Tripulantes: {nave.CapacidadeMaximaTripulantes}");
                Console.WriteLine($"Distância Máxima de Viagem (UA): {nave.DistanciaMaximaViagem}");

                Console.Write("Objetivos Suportados: ");
                foreach (var objetivo in nave.TiposDeMissaoSuportados)
                {
                    Console.Write($"{objetivo} ");
                }

                Console.WriteLine("\n-------------------------------------------");
            }

            Console.WriteLine("\n=============== MISSÕES ===================\n");

            foreach (var missao in missoes)
            {
                Console.WriteLine($"Nome da Missão: {missao.Nome}");
                Console.WriteLine($"Objetivo: {missao.Objetivo}");
                Console.WriteLine($"Data de Início: {missao.DataLancamento.ToShortDateString()}");
                Console.WriteLine($"Data de Término: {missao.DataRetornoPrevisto.ToShortDateString()}");
                Console.WriteLine($"Estado: {missao.EstadoMissao}");
                Console.WriteLine($"Planeta Alvo: {missao.Destino.Nome}");
                Console.WriteLine($"Nave Designada: {missao.Nave.Nome}");
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("\n============ ASTRONAUTAS ==================\n");

            foreach (var astro in astronautas)
            {
                Console.WriteLine($"Nome: {astro.Nome}");
                Console.WriteLine($"Idade: {astro.Idade}");
                Console.WriteLine($"Nacionalidade: {astro.Nacionalidade}");
                Console.WriteLine($"Data de Nascimento: {astro.DataNascimento.ToShortDateString()}");
                Console.WriteLine($"Situação Atual: {astro.EstadoAstronauta}");
                Console.WriteLine($"Tripulando Nave: {(astro.TripulandoNave != null ? astro.TripulandoNave.Nome : "Nenhuma")}");
                Console.WriteLine("-------------------------------------------");
            }
        }

    }
}

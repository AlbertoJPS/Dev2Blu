using Sistema_Central.Entities;
using Sistema_Central.Utilitários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Central
{
    public class Lancamento
    {
        public static void LancarMissao(List<Missao> missoes, List<Astronauta> astronautas)
        {
            var missoesPendentes = new List<Missao>();
            foreach (var missao in missoes)
            {
                if (missao.EstadoMissao == SituacaoMissao.Pendente)
                {
                    missoesPendentes.Add(missao);
                }
            }

            if (missoesPendentes.Count == 0)
            {
                Console.WriteLine("\nNão há missões agendadas para lançar.");
                Console.ReadKey();
                return;
            }
            

            for (int i = 0; i < missoesPendentes.Count; i++)
            {
                var missao = missoesPendentes[i];
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{i + 1} - {missao.Nome} - Missão de {missao.Objetivo} (Destino: {missao.Destino.Nome}, Nave: {missao.Nave.Nome}) - Duração: {missao.DuracaoMissao} dias");
                Console.ResetColor();
            }

            Console.Write("\nEscolha o número da missão que deseja lançar: ");
            if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > missoesPendentes.Count)
            {
                Console.WriteLine("\nOpção inválida.");
                Console.ReadKey();
                return;
            }

            var missaoSelecionada = missoesPendentes[escolha - 1];
            var nave = missaoSelecionada.Nave;

            // Filtra astronautas disponíveis
            var disponiveis = new List<Astronauta>();
            foreach (var astronauta in astronautas)
            {
                if (astronauta.EstadoAstronauta == SituacaoAstronauta.Disponivel)
                {
                    disponiveis.Add(astronauta);
                }
            }

            if (disponiveis.Count < nave.CapacidadeMaximaTripulantes)
            {
                Console.WriteLine($"\nNúmero insuficiente de astronautas disponíveis ({disponiveis.Count}/{nave.CapacidadeMaximaTripulantes}).");
                Console.ReadKey();
                return;
            }

            // Escolha da quantidade de tripulantes
            int minimo = nave.CapacidadeMaximaTripulantes / 2;
            int maximo = nave.CapacidadeMaximaTripulantes;

            Console.Write($"\nDigite o número de tripulantes (mínimo {minimo}, máximo {maximo}): ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < minimo || quantidade > maximo)
            {
                Console.Write($"Valor inválido. Digite um número entre {minimo} e {maximo}: ");
            }

            // Escolha entre automático ou manual
            Console.Write("\nDeseja selecionar a tripulação automaticamente (A) ou manualmente (M)? ");
            string modo = Console.ReadLine().ToUpper();

            var tripulacaoEscolhida = new List<Astronauta>();
            var random = new Random();

            if (modo == "A")
            {
                while (tripulacaoEscolhida.Count < quantidade)
                {
                    var sorteado = disponiveis[random.Next(disponiveis.Count)];
                    if (!tripulacaoEscolhida.Contains(sorteado))
                    {
                        sorteado.SetarEmMissao(nave);
                        tripulacaoEscolhida.Add(sorteado);
                    }
                }
            }
            else if (modo == "M")
            {
                while (tripulacaoEscolhida.Count < quantidade)
                {
                    Console.Clear();
                    Console.WriteLine("\n=========== SELEÇÃO DE TRIPULAÇÃO ===========");
                    Console.WriteLine($"Faltam {quantidade - tripulacaoEscolhida.Count} vaga(s).");
                    Console.WriteLine("\nDisponíveis:");

                    var disponiveisRestantes = new List<Astronauta>();
                    foreach (var astro in disponiveis)
                    {
                        if (!tripulacaoEscolhida.Contains(astro))
                        {
                            disponiveisRestantes.Add(astro);
                        }
                    }

                    for (int i = 0; i < disponiveisRestantes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {disponiveisRestantes[i].Nome} ({disponiveisRestantes[i].Nacionalidade}, {disponiveisRestantes[i].Idade})");
                    }

                    Console.Write("\nEscolha o número do astronauta: ");
                    if (!int.TryParse(Console.ReadLine(), out int indice) || indice < 1 || indice > disponiveisRestantes.Count)
                    {
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        continue;
                    }

                    var selecionado = disponiveisRestantes[indice - 1];
                    selecionado.SetarEmMissao(nave);
                    tripulacaoEscolhida.Add(selecionado);
                }
            }
            else
            {
                Console.WriteLine("\nModo inválido.");
                Console.ReadKey();
                return;
            }

            // Pergunta data de lançamento
            Console.Write("\nDigite a data de lançamento (formato: dd/MM/yyyy): ");
            DateTime dataLancamento;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataLancamento))
            {
                Console.Write("Data inválida. Tente novamente (formato: dd/MM/yyyy): ");
            }

            DateTime dataRetorno = dataLancamento.AddDays(missaoSelecionada.DuracaoMissao);

            // Mostrar resumo e confirmar
            Console.Clear();
            Console.WriteLine($"\nMISSÃO: {missaoSelecionada.Nome}");
            Console.WriteLine($"Objetivo: {missaoSelecionada.Objetivo}");
            Console.WriteLine($"Destino: {missaoSelecionada.Destino.Nome}");
            Console.WriteLine($"Nave: {nave.Nome}");
            Console.WriteLine($"Duração: {missaoSelecionada.DuracaoMissao} dias");
            Console.WriteLine($"Data de Lançamento: {dataLancamento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Data de Retorno Previsto: {dataRetorno.ToString("dd/MM/yyyy")}");
            Console.WriteLine("\nTripulação:");
            foreach (var astro in tripulacaoEscolhida)
            {
                Console.WriteLine($"- {astro.Nome} ({astro.Nacionalidade}, {astro.Idade})");
            }

            Console.Write("\nConfirmar lançamento da missão? (S/N): ");
            var confirmacao = Console.ReadLine().ToUpper();
            if (confirmacao != "S")
            {
                Console.WriteLine("\nLançamento cancelado. Nenhum dado foi alterado.");
                Console.ReadKey();
                return;
            }

            // Aplica os dados na missão e nave
            missaoSelecionada.DataLancamento = dataLancamento;
            missaoSelecionada.DataRetornoPrevisto = dataRetorno;
            missaoSelecionada.EstadoMissao = SituacaoMissao.EmAndamento;
            missaoSelecionada.TripulacaoMissao = tripulacaoEscolhida;
            nave.EstadoAtualNave = SituacaoNave.EmMissao;

            Console.WriteLine("\nMissão lançada com sucesso!");
            Console.ReadKey();
        }


    }
}

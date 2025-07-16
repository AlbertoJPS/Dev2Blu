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
            var missoesPendentes = missoes.Where(missao => missao.EstadoMissao == SituacaoMissao.Pendente).ToList();
            Console.Clear();

            if (missoesPendentes.Count == 0)
            {
                Console.WriteLine("\nNão há missões agendadas para lançar.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\n=====================================");
            Console.WriteLine("\n========= MISSÕES PENDENTES =========");
            Console.WriteLine("\n=====================================\n\n");

            for (int i = 0; i < missoesPendentes.Count; i++)
            {
                var missao = missoesPendentes[i];
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{i + 1} - {missao.Nome} - Missão de {missao.Objetivo} (Destino: {missao.Destino.Nome}, Nave: {missao.Nave.Nome}) - Duração da Missão: {missao.DuracaoMissao} dias");
                Console.ResetColor();
            }
            Console.WriteLine("\n=====================================\n");
            Console.Write("\nEscolha o número da missão que deseja lançar: ");
            if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > missoesPendentes.Count)
            {
                Console.WriteLine("\nOpção inválida.");
                Console.ReadKey();
                return;
            }

            var missaoSelecionada = missoesPendentes[escolha - 1];
            var nave = missaoSelecionada.Nave;

            var disponiveis = astronautas.Where(a => a.EstadoAstronauta == SituacaoAstronauta.Disponivel).ToList();

            if (disponiveis.Count < nave.CapacidadeMaximaTripulantes)
            {
                Console.WriteLine($"\nNúmero insuficiente de astronautas disponíveis ({disponiveis.Count}/{nave.CapacidadeMaximaTripulantes}).");
                Console.ReadKey();
                return;
            }

            var tripulacaoSorteada = new List<Astronauta>();
            var rnd = new Random();

            while (tripulacaoSorteada.Count < nave.CapacidadeMaximaTripulantes)
            {
                var sorteado = disponiveis[rnd.Next(disponiveis.Count)];
                if (!tripulacaoSorteada.Contains(sorteado))
                {
                    sorteado.SetarEmMissao(nave);
                    tripulacaoSorteada.Add(sorteado);
                }
            }

            missaoSelecionada.EstadoMissao = SituacaoMissao.EmAndamento;
            nave.EstadoAtualNave = SituacaoNave.EmMissao;

            Console.WriteLine($"\nMissão \"{missaoSelecionada.Nome}\" lançada com sucesso!");
            Console.WriteLine("\n=====================================\n");
            Console.WriteLine("Tripulação embarcada:");
            foreach (var astronauta in tripulacaoSorteada)
            {
                Console.WriteLine($"- {astronauta.Nome} ({astronauta.Nacionalidade}, {astronauta.Idade})");
            }
            Console.WriteLine("\n=====================================\n");
            Console.ReadKey();
        }
    }
}

using Sistema_Central.Entities;
using Sistema_Central.Utilitários;

namespace Sistema_Central
{
    public class AtualizarTempo
    {
        private static readonly Random _random = new();

        public static void AvancarTempo(List<Missao> missoes, List<Astronauta> astronautas, List<Nave> naves)
        {
            
            Console.Write("Quantos dias deseja avançar? ");

            if (!int.TryParse(Console.ReadLine(), out int diasAvancados) || diasAvancados <= 0)
            {
                Console.WriteLine("Entrada inválida. Dias devem ser um número inteiro positivo.");
                return;
            }

            Console.WriteLine($"\nAvançando {diasAvancados} dias nas missões em andamento...\n");

            foreach (var missao in missoes)
            {
                if (missao.EstadoMissao == SituacaoMissao.EmAndamento)
                {
                    missao.DiasRestantes -= diasAvancados;

                    if (missao.DiasRestantes <= 0)
                    {
                        missao.EstadoMissao = SortearResultadoMissao();
                        AtualizarEstadoNave(missao);
                        AtualizarEstadoAstronautas(missao);

                        Console.WriteLine($"Missão \"{missao.Nome}\" finalizada como: {missao.EstadoMissao}");
                    }
                    else
                    {
                        Console.WriteLine($"Missão \"{missao.Nome}\" agora tem {missao.DiasRestantes} dias restantes.");
                    }
                }
            }
            Console.WriteLine("\nAtualização concluída. Pressione qualquer tecla para continuar...");
        }
        private static SituacaoMissao SortearResultadoMissao()
        {
            int chance = _random.Next(1, 101);

            if (chance <= 10)
            {
                return SituacaoMissao.Falhou;
            }
            else if (chance <= 40)
            {
                return SituacaoMissao.Cancelada;
            }
            else
            {
                return SituacaoMissao.Concluida;
            }
        }
        private static void AtualizarEstadoNave(Missao missao)
        {
            var nave = missao.Nave;

            if (nave == null)
            {
                return;
            }

            switch (missao.EstadoMissao)
            {
                case SituacaoMissao.Falhou:
                    nave.EstadoAtualNave = SituacaoNave.Perdida;
                    break;

                case SituacaoMissao.Cancelada:
                    int chance = _random.Next(1, 101);
                    nave.EstadoAtualNave = (chance <= 60) ? SituacaoNave.Avariada : SituacaoNave.Disponivel;
                    break;

                case SituacaoMissao.Concluida:
                    nave.EstadoAtualNave = SituacaoNave.Disponivel;
                    nave.TripulacaoEmbarcada.Clear();
                    break;
            }
        }
        private static void AtualizarEstadoAstronautas(Missao missao)
        {
            foreach (var astro in missao.TripulacaoMissao)
            {
                switch (missao.EstadoMissao)
                {
                    case SituacaoMissao.Falhou:
                        astro.EstadoAstronauta = SituacaoAstronauta.Morto;
                        break;

                    case SituacaoMissao.Cancelada:
                        int chance = _random.Next(1, 101);
                        if (chance <= 30)
                        {
                            astro.EstadoAstronauta = SituacaoAstronauta.Disponivel;
                            astro.TripulandoNave = null;
                        }
                        else
                        {
                            astro.EstadoAstronauta = SituacaoAstronauta.Ferido;
                        }
                        break;

                    case SituacaoMissao.Concluida:
                        astro.EstadoAstronauta = SituacaoAstronauta.Disponivel;
                        astro.TripulandoNave = null;
                        break;
                }
            }
        }
    }
}

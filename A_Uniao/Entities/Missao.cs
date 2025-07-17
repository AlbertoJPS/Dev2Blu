using Sistema_Central.Utilitários;

namespace Sistema_Central.Entities
{
    public class Missao
    {

        public string Nome { get; set; }
        public ObjetivoMissao Objetivo { get; set; }
        public DateTime DataLancamento { get; set; }
        public int DuracaoMissao { get; set; }
        public DateTime DataRetornoPrevisto { get; set; }
        public Planeta Destino { get; set; }
        public Nave Nave { get; set; }
        public List<Astronauta> TripulacaoMissao { get; set; }
        public SituacaoMissao EstadoMissao { get; set; }

        public Missao(string nome, ObjetivoMissao objetivo, int duracaoMissao, Planeta destino, Nave nave)
        {
            Nome = nome;
            Objetivo = objetivo;
            DataLancamento = DateTime.MinValue;
            DuracaoMissao = duracaoMissao;
            DataRetornoPrevisto = DateTime.MinValue;
            Destino = destino;
            Nave = nave;
            TripulacaoMissao = new List<Astronauta>();
            EstadoMissao = SituacaoMissao.Pendente;
        }

        public Missao(string nome, ObjetivoMissao objetivo, DateTime dataLancamento, int duracaoMissao, Planeta destino, Nave nave, List<Astronauta> tripulacaoMissao)
           : this(nome, objetivo, duracaoMissao, destino, nave)
        {
            DataLancamento = dataLancamento;
            DataRetornoPrevisto = dataLancamento.AddDays(duracaoMissao);
            TripulacaoMissao = tripulacaoMissao;
        }
        public void IniciarMissao(DateTime dataInicio)
        {
            DataLancamento = dataInicio;
            DataRetornoPrevisto = dataInicio.AddDays(DuracaoMissao);
            EstadoMissao = SituacaoMissao.EmAndamento;
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

    }
}

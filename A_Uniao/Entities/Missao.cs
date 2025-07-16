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
        public List<Astronauta> Tripulacao { get; set; }
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
            Tripulacao = new List<Astronauta>();
            EstadoMissao = SituacaoMissao.Pendente;
        }

        public Missao(string nome, ObjetivoMissao objetivo, DateTime dataLancamento, int duracaoMissao, DateTime dataRetornoPrevisto, Planeta destino, Nave nave)
        {
            Nome = nome;
            Objetivo = objetivo;
            DataLancamento = dataLancamento;
            DuracaoMissao = duracaoMissao;
            DataRetornoPrevisto = dataLancamento.AddDays(duracaoMissao);
            Destino = destino;
            Nave = nave;
            Tripulacao = new List<Astronauta>();
            EstadoMissao = SituacaoMissao.Pendente;
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
            Console.WriteLine($"Data de Início: {missao.DataLancamento.ToShortDateString()}");
            Console.WriteLine($"Data de Término: {missao.DataRetornoPrevisto.ToShortDateString()}");
            Console.WriteLine($"Estado: {missao.EstadoMissao}");
            Console.WriteLine($"Planeta Alvo: {missao.Destino.Nome}");
            Console.WriteLine($"Nave Designada: {missao.Nave.Nome}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}

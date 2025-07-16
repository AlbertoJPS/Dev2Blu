using Sistema_Central.Utilitários;

namespace Sistema_Central.Entities
{
    public class Missao
    {
        public string Nome { get; set; }
        public ObjetivoMissao Objetivo { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataRetornoPrevisto { get; set; }
        public Planeta Destino { get; set; }
        public Nave Nave { get; set; }
        public List<Astronauta> Tripulacao { get; set; }
        public SituacaoMissao EstadoMissao { get; set; }

        public Missao(string nome, ObjetivoMissao objetivo, DateTime dataLancamento, DateTime dataRetornoPrevisto, Planeta destino, Nave nave)
        {
            Nome = nome;
            Objetivo = objetivo;
            DataLancamento = dataLancamento;
            DataRetornoPrevisto = dataRetornoPrevisto;
            Destino = destino;
            Nave = nave;
            Tripulacao = new List<Astronauta>();
            EstadoMissao = SituacaoMissao.Pendente;
        }
    }
}

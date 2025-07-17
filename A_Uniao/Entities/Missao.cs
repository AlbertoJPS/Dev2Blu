using Sistema_Central.Utilitários;

namespace Sistema_Central.Entities
{
    public class Missao
    {
        private int _DiasRestantes = -1;

        public string Nome { get; set; }
        public ObjetivoMissao Objetivo { get; set; }
        public DateTime DataLancamento { get; set; }
        public int DuracaoMissao { get; set; }
        public DateTime DataRetornoPrevisto { get; set; }
        public int DiasRestantes
        {
            get
            {
                if (_DiasRestantes == -1)
                {
                    _DiasRestantes = DuracaoMissao;
                }
                return _DiasRestantes;
            }
            set
            {
                _DiasRestantes = value;
            }
        }
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
    }
}

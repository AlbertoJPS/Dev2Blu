using Sistema_Central.Utilitários;

namespace Sistema_Central.Entities
{
    public class Astronauta
    {
        public string Nome { get; set; }
        public PaisAstronauta Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public SituacaoAstronauta EstadoAstronauta { get; set; }
        public Nave? TripulandoNave { get; set; }

        public int Idade => (int)(DateTime.Now - DataNascimento).TotalDays / 365;

        public Astronauta(string nome, PaisAstronauta nacionalidade, DateTime dataNascimento, SituacaoAstronauta estadoAstronauta = SituacaoAstronauta.Disponivel)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
            EstadoAstronauta = estadoAstronauta;
            TripulandoNave = null;
        }
    }
}

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

        public Astronauta(string nome, PaisAstronauta nacionalidade, DateTime dataNascimento)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
            EstadoAstronauta = SituacaoAstronauta.Disponivel;
            TripulandoNave = null;
        }

        public Astronauta(string nome, PaisAstronauta nacionalidade, DateTime dataNascimento, SituacaoAstronauta estadoAstronauta, Nave? tripulandoNave)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
            EstadoAstronauta = estadoAstronauta;
            TripulandoNave = tripulandoNave;
        }

        public void SetarDisponivel()
        {
            EstadoAstronauta = SituacaoAstronauta.Disponivel;
            TripulandoNave = null;
        }

        public void SetarEmMissao(Nave nave)
        {
            EstadoAstronauta = SituacaoAstronauta.EmMissao;
            TripulandoNave = nave;
        }

        public void SetarFerido()
        {
            EstadoAstronauta = SituacaoAstronauta.Ferido;
        }

        public void SetarMorto()
        {
            EstadoAstronauta = SituacaoAstronauta.Morto;
        }

        public static void MostrarAstronauta(Astronauta astronauta)
        {
            Console.WriteLine($"Nome: {astronauta.Nome}");
            Console.WriteLine($"Idade: {astronauta.Idade}");
            Console.WriteLine($"Nacionalidade: {astronauta.Nacionalidade}");
            Console.WriteLine($"Nascimento: {astronauta.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Situação: {astronauta.EstadoAstronauta}");
            Console.WriteLine($"Tripulando: {(astronauta.TripulandoNave != null ? astronauta.TripulandoNave.Nome : "Nenhuma")}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}

using Sistema_Central.Utilitários;

namespace Sistema_Central.Entities
{
    public class Planeta
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double DistanciaEmUA { get; set; } // 1 UA ≈ 149.597.870,7 km
        public SituacaoPlaneta SituacaoAtual { get; set; }

        public Planeta(string nome, string descricao, double distanciaEmUA, SituacaoPlaneta situacaoAtual)
        {
            Nome = nome;
            Descricao = descricao;
            DistanciaEmUA = distanciaEmUA;
            SituacaoAtual = situacaoAtual;
        }
    }
}

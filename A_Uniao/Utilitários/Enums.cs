
namespace Sistema_Central.Utilitários
{
    public enum ObjetivoMissao
    {
        Reconhecimento,
        ColetaRecursos,
        Colonizacao,
        Combate,
        Pesquisa
    }

    public enum SituacaoNave
    {
        Disponivel,
        EmMissao,
        Perdida,
        Avariada
    }
    public enum PorteNave
    {
        Pequena,
        Média,
        Grande
    }

    public enum SituacaoAstronauta
    {
        Disponivel,
        EmMissao,
        Ferido,
        Morto
    }

    public enum SituacaoMissao
    {
        Pendente,
        EmAndamento,
        Concluida,
        Cancelada,
        Falhou
    }

    public enum SituacaoPlaneta
    {
        Habitavel,
        Inexplorado,
        Colonizavel,
        Hostil,
        FonteDeRecursos
    }

    public enum PaisFabricante
    {
        EstadosUnidos,
        Russia,
        China,
        UniãoEuropeia,
        India,
    }
    public enum PaisAstronauta
    {
        EstadosUnidos,
        Russia,
        China,
        França,
        Alemanha,
        Japao,
        Italia,
        Canada
    }
}

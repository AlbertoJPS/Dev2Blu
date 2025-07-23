
using System.ComponentModel;

namespace Sistema_Central.Utilitários
{
    public enum ObjetivoMissao
    {
        Reconhecimento,
        [Description("Coleta de Recursos")]
        ColetaRecursos,
        [Description("Colonização")]
        Colonizacao,
        Combate,
        Pesquisa
    }
    public enum SituacaoMissao
    {
        Pendente,
        [Description("Em Andamento")]
        EmAndamento,
        [Description("Concluída")]
        Concluida,
        Cancelada,
        Falhou
    }

    public enum SituacaoNave
    {
        [Description("Disponível")]
        Disponivel,
        [Description("Em Missão")]
        EmMissao,
        Perdida,
        Avariada
    }
    public enum PorteNave
    {
        Pequena,
        [Description("Média")]
        Media,
        Grande
    }

    public enum SituacaoAstronauta
    {
        Disponivel,
        [Description("Em Missão")]
        EmMissao,
        Ferido,
        Morto
    }

    public enum SituacaoPlaneta
    {
        [Description("Habitável")]
        Habitavel,
        Inexplorado,
        [Description("Hostíl")]
        Hostil,
        [Description("Fonte de Recursos")]
        FonteDeRecursos
    }

    public enum PaisFabricante
    {
        [Description("Estados Unidos")]
        EstadosUnidos,
        [Description("Rússia")]
        Russia,
        China,
        [Description("União Europeia")]
        UniaoEuropeia,
        [Description("Índia")]
        India,
    }
    public enum PaisAstronauta
    {
        [Description("Estados Unidos")]
        EstadosUnidos,
        [Description("Rússia")]
        Russia,
        China,
        [Description("França")]
        Franca,
        Alemanha,
        [Description("Japão")]
        Japao,
        [Description("Itália")]
        Italia,
        [Description("Canadá")]
        Canada
    }
}

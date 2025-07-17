using Sistema_Central.Utilitários;
using System;

namespace Sistema_Central.Entities
{
    public class Nave
    {
        private static readonly Random _random = new();
        private int? _capacidadeMaximaTripulantes;
        private double? _distanciaMaximaViagem;

        public string Nome { get; set; }
        public string Modelo { get; set; }
        public PorteNave Porte { get; set; }
        public PaisFabricante Fabricante { get; set; }
        public double DistanciaMaximaViagem
        {
            get
            {
                if (!_distanciaMaximaViagem.HasValue)
                {
                    switch (Porte)
                    {
                        case PorteNave.Pequena:
                            _distanciaMaximaViagem = _random.NextDouble() * (5 - 2) + 2; // 2 a 5 UA
                            break;
                        case PorteNave.Média:
                            _distanciaMaximaViagem = _random.NextDouble() * (10 - 6) + 6; // 6 a 10 UA
                            break;
                        case PorteNave.Grande:
                            _distanciaMaximaViagem = _random.NextDouble() * (15 - 11) + 11; // 11 a 15 UA
                            break;
                        default:
                            _distanciaMaximaViagem = 0;
                            break;
                    }
                }
                return _distanciaMaximaViagem.Value;
            }
        }
        public List<Astronauta> TripulacaoEmbarcada { get; set; }
        public SituacaoNave EstadoAtualNave { get; set; }
        public List<ObjetivoMissao> TiposDeMissaoSuportados { get; set; }

        public int CapacidadeMaximaTripulantes
        {
            get
            {
                if (!_capacidadeMaximaTripulantes.HasValue)
                {
                    switch (Porte)
                    {
                        case PorteNave.Pequena:
                            _capacidadeMaximaTripulantes = _random.Next(1, 5);  // 1 a 4
                            break;
                        case PorteNave.Média:
                            _capacidadeMaximaTripulantes = _random.Next(5, 10); // 5 a 9
                            break;
                        case PorteNave.Grande:
                            _capacidadeMaximaTripulantes = _random.Next(10, 16); // 10 a 15
                            break;
                        default:
                            _capacidadeMaximaTripulantes = 0;
                            break;
                    }
                }
                return _capacidadeMaximaTripulantes.Value;
            }
        }
        public Nave(string nome, string modelo, PorteNave porte, PaisFabricante fabricante, SituacaoNave estadoNave, List<ObjetivoMissao> tiposDeMissao)
        {
            Nome = nome;
            Modelo = modelo;
            Porte = porte;
            Fabricante = fabricante;
            EstadoAtualNave = estadoNave;
            TiposDeMissaoSuportados = tiposDeMissao;
            TripulacaoEmbarcada = new List<Astronauta>();
        }

        public Nave(string nome, string modelo, PorteNave porte, PaisFabricante fabricante, SituacaoNave estadoNave, List<ObjetivoMissao> tiposDeMissao,  double distanciaMaximaViagem, int capacidadeMaximaTripulantes)
        {
            Nome = nome;
            Modelo = modelo;
            Porte = porte;
            Fabricante = fabricante;
            EstadoAtualNave = estadoNave;
            TiposDeMissaoSuportados = tiposDeMissao;
            TripulacaoEmbarcada = new List<Astronauta>();
            _distanciaMaximaViagem = distanciaMaximaViagem;
            _capacidadeMaximaTripulantes = capacidadeMaximaTripulantes;
        }

        public static void MostrarNave(Nave nave)
        {
            Console.WriteLine($"Nome: {nave.Nome} | Modelo: {nave.Modelo}");
            Console.WriteLine($"Porte: {nave.Porte}");
            Console.WriteLine($"Fabricante: {nave.Fabricante}");
            Console.WriteLine($"Situação Atual: {nave.EstadoAtualNave}");
            Console.WriteLine($"Capacidade de Tripulantes: {nave.CapacidadeMaximaTripulantes}");
            Console.WriteLine($"Distância Máxima (UA): {nave.DistanciaMaximaViagem}");

            Console.Write("Objetivos Suportados: ");
            foreach (var objetivo in nave.TiposDeMissaoSuportados)
            {
                Console.Write($"{objetivo} ");
            }
            Console.WriteLine(); // quebra de linha após objetivos

            // Mostrar a tripulação da nave
            if (nave.TripulacaoEmbarcada != null && nave.TripulacaoEmbarcada.Count > 0)
            {
                var nomesTripulantes = nave.TripulacaoEmbarcada.Select(t => t.Nome).ToList();
                Console.WriteLine($"Tripulação Atual: {string.Join(", ", nomesTripulantes)}");
            }
            else
            {
                Console.WriteLine("Tripulação Atual: [Nenhum tripulante designado]");
            }

            Console.WriteLine("-------------------------------------------");
        }
    }
}

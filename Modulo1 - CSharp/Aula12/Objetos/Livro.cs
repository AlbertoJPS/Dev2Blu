
namespace Aula12.Objetos
{
    public class Livro
    {
        private int _PaginaAtual = 0;

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int QuantidadePaginas { get; private set; }

        public Livro(string titulo, string autor, int quantidadePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            QuantidadePaginas = quantidadePaginas;
        }

        public int Ler()
        {
            _PaginaAtual++;
            Console.WriteLine($"Você leu a página número {_PaginaAtual}");

            return _PaginaAtual;
        }
    }
}



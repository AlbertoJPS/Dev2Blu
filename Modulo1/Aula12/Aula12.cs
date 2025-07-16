using Aula12.Objetos;

namespace Aula12
{
    class Program
    {
        public static void Main()
        {

            //Carro

            var Honda = new Carro();
            Honda.Marca = "Honda";
            Honda.Modelo = "Civic";
            Honda.Ano = 2001;

            var corsa = new Carro();
            Honda.Marca = "Chevrolett";
            Honda.Modelo = "Corsa";
            Honda.Ano = 1998;


            Honda.Acelerar(250);
            corsa.Acelerar(500);


            //Animal

            var animal = new Animal();
            animal.Nome = "Lobo";
            animal.NomeCientifico = "Canis lupus";
            animal.Idade = 5;

            for (int i = 0; i < 10; i++)
            {
                animal.Comer();
                Thread.Sleep(500);
            }

            //Livro

            var livro = new Livro("Harry Potter: A ordem da Fênix", "J.K Rolling", 704);

            var paginaAtual = 0;
            while (paginaAtual != livro.QuantidadePaginas)
            {
                paginaAtual = livro.Ler();
                Thread.Sleep(100);
            }

            //Calculadora

            var calculadora = new Calculadora();
            calculadora.Somar(4, 18);
            calculadora.Subtrair(7.5, 22.8);
            calculadora.Multiplicar(64, 2.5);
            calculadora.Dividir(255, 8);
        }
    }
}


namespace Aula12.Objetos
{
    public class Animal
    {

        private const int TAMANHO_BARRIGA = 5;
        private int _Saciedade = 0;

        public string Nome { get; set; }
        public string NomeCientifico { get; set; }
        public int Idade { get; set; }

        public void Comer()
        {
            if (_Saciedade == TAMANHO_BARRIGA)
            {
                Console.WriteLine($"{Nome} não está mais com fome!");
            }
            else
            {
                Console.WriteLine($"{Nome}  está se alimentando");
                _Saciedade += 1;
            }
        }
    }
